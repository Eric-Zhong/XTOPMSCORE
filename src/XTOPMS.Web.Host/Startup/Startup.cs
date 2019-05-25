using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Abp.Extensions;
using XTOPMS.Configuration;
using XTOPMS.Identity;
using Abp.Hangfire;
using Abp.AspNetCore.SignalR.Hubs;
using Hangfire;
using Hangfire.MySql.Core;
using System.Data;
using XTOPMS.Alibaba;
using XTOPMS.DataSyncServices;

namespace XTOPMS.Web.Host.Startup
{
    public class Startup
    {
        private const string _defaultCorsPolicyName = "localhost";

        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddMvc(
                options => options.Filters.Add(new CorsAuthorizationFilterFactory(_defaultCorsPolicyName))
            );

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.AddSignalR();

            // Configure CORS for angular2 UI
            services.AddCors(
                options => options.AddPolicy(
                    _defaultCorsPolicyName,
                    builder => builder
                        .WithOrigins(
                            // App:CorsOrigins in appsettings.json can contain more than one address separated by comma.
                            _appConfiguration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(o => o.RemovePostFix("/"))
                                .ToArray()
                        )
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                )
            );

            // Swagger - Enable this line and the related lines in Configure method to enable swagger UI
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "XTOPMS API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);

                // Define the BearerAuth scheme that's in use
                options.AddSecurityDefinition("bearerAuth", new ApiKeyScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
            });


            // HangFire - Enable backgroup process component.
            // 20190419 - Eric.
            services.AddHangfire(config =>
            {

                string connectionString = _appConfiguration.GetConnectionString("Default");

                config.UseStorage(
                    new MySqlStorage(
                        connectionString,
                        new MySqlStorageOptions
                        {
                            TransactionIsolationLevel = IsolationLevel.ReadCommitted,
                            QueuePollInterval = TimeSpan.FromSeconds(15),
                            JobExpirationCheckInterval = TimeSpan.FromHours(1),
                            CountersAggregateInterval = TimeSpan.FromMinutes(5),
                            PrepareSchemaIfNecessary = true,
                            DashboardJobListLimit = 50000,
                            TransactionTimeout = TimeSpan.FromMinutes(1),
                            TablePrefix = "Hangfire"
                        }
                    ));
                        
            });


            // Configure Abp and Dependency Injection
            return services.AddAbp<XTOPMSWebHostModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                )
            );
        } 

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory
            )
        {
            app.UseAbp(options => { options.UseAbpRequestLocalization = false; }); // Initializes ABP framework.

            app.UseCors(_defaultCorsPolicyName); // Enable CORS!

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseAbpRequestLocalization();


            app.UseSignalR(routes =>
            {
                routes.MapHub<AbpCommonHub>("/signalr");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();
            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(_appConfiguration["App:ServerRootAddress"] + "/swagger/v1/swagger.json", "XTOPMS API V1");
                options.IndexStream = () => Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("XTOPMS.Web.Host.wwwroot.swagger.ui.index.html");
            }); // URL: /swagger


            // HangFire
            // 20190419 - Eric.
            // HangFire分布式后端作业调度框架服务 https://yq.aliyun.com/articles/229859
            app.UseHangfireServer(
                new BackgroundJobServerOptions {
                    WorkerCount = 1,
                    SchedulePollingInterval = TimeSpan.FromMinutes(1)
                    }
                );

            app.UseHangfireDashboard("/hangfire");
            /*
            */
            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[]
                {
                    // new AbpHangfireAuthorizationFilter("MyHangFireDashboardPermissionName")
                    new AbpHangfireAuthorizationFilter("HangFire.Dashboard")
                },
                AppPath = "http://xto.biztalkgroup.com",
                StatsPollingInterval = 60000
            });

            // BackgroundJob.Enqueue(() => Console.WriteLine("Handfire regisited and running."));
            // BackgroundJob.Schedule(() => Console.WriteLine("Handfire running"), TimeSpan.FromSeconds(20));
            // RecurringJob.AddOrUpdate(() => Console.WriteLine("Recurrent running"), Cron.Minutely);

            RecurringJob.AddOrUpdate<AccessTokenRefreshProcess>("Alibaba Access-Token Refresh Service", (t) => t.Execute(null), Cron.Daily);
            RecurringJob.AddOrUpdate<RefreshTokenRefreshProcess>("Alibaba Refresh-Token Refresh Service", (t) => t.Execute(null), Cron.Daily);
            // RecurringJob.AddOrUpdate<DataSyncServiceProcess>("Data Sync Service Schedule Job)", (t) => t.Execute(null), Cron.Hourly);
            RecurringJob.AddOrUpdate<AlibabaCallbackMessageProcess>("Alibaba Callback Message Process Service", (t) => t.Execute(null), Cron.Minutely);

        }
    }
}
