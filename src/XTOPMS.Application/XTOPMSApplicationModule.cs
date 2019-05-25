using Abp.AutoMapper;
using Abp.MailKit;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XTOPMS.Authorization;
using XTOPMS.Email;
using Abp.Configuration.Startup;

namespace XTOPMS
{
    [DependsOn(
        typeof(XTOPMSCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AbpMailKitModule))]
    public class XTOPMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<XTOPMSAuthorizationProvider>();
            // HangFire - Enable backgroup process component.
            // 20190419 - Eric. 好多地方都可以配置，不知道重复定义会有什么问题。
            // Configuration.BackgroundJobs.UseHangfire();
        }


        public override void PostInitialize()
        {
            base.PostInitialize();

            // 20190420 - Regist background worker.
            // https://www.cnblogs.com/farb/p/ABPBackgroundJobsAndWorkers.html
            // 使用了 Worker 方式，但无法在 Hangfire 中看到 Job.

            /*
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<AccessTokenRefreshWorker>());
            */
            // 20190524 - Eric. Add MailKit SMTP Setting.
            Configuration.ReplaceService<IMailKitSmtpBuilder, XTOPMSMailKitSmtpBuilder>();
            Configuration.Modules.AbpMailKit().SecureSocketOption = MailKit.Security.SecureSocketOptions.SslOnConnect;
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(XTOPMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
