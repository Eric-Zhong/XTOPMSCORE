using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
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
            // ! 控制 Entity History 功能
            // Configuration.EntityHistory.IsEnabled = true; // Default value is true.
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
