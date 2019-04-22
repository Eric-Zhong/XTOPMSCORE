using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XTOPMS.Configuration;
using Abp.Hangfire.Configuration;

namespace XTOPMS.Web.Host.Startup
{
    [DependsOn(
       typeof(XTOPMSWebCoreModule))]
    public class XTOPMSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public XTOPMSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }


        public override void PreInitialize()
        {
            base.PreInitialize();
            // HangFire - Enable backgroup process component.
            // 20190419 - Eric.
            Configuration.BackgroundJobs.UseHangfire();
        }


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTOPMSWebHostModule).GetAssembly());
        }
    }
}
