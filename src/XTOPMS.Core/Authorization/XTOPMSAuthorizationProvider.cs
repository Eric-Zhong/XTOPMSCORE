using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace XTOPMS.Authorization
{
    public class XTOPMSAuthorizationProvider : AuthorizationProvider
    {
        // 向全局系统中注册登记可用的权限控制实体
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users")); // 用在了判断当前用户是否有访问 UserAppService 权限
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, XTOPMSConsts.LocalizationSourceName);
        }
    }
}
