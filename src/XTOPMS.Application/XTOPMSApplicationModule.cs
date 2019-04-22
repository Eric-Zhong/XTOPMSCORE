using Abp.AutoMapper;
using Abp.Hangfire.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using XTOPMS.Alibaba;
using XTOPMS.Authorization;

namespace XTOPMS
{
    [DependsOn(
        typeof(XTOPMSCoreModule), 
        typeof(AbpAutoMapperModule))]
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
