using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XTOPMS.Configuration;
using Abp.Hangfire.Configuration;
using Abp.MailKit;
using XTOPMS.Email;
using Abp.Configuration.Startup;

namespace XTOPMS.Web.Host.Startup
{
    [DependsOn(
        typeof(XTOPMSWebCoreModule),
        typeof(AbpMailKitModule)
        )]
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
            // 20190524 - Eric. Add MailKit SMTP Setting.
            // TODO: 但在实际使用中发现，按官网描述的方式注册后，邮件无法正常发送，目前还没有解决。
            Configuration.ReplaceService<IMailKitSmtpBuilder, XTOPMSMailKitSmtpBuilder>();
        }


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XTOPMSWebHostModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            base.PostInitialize();
        }
    }
}
