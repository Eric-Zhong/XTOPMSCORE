using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace XTOPMS.Authorization
{
    public class XTOPMSAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            #region API Permissions
            // Customer API
            context.CreatePermission(PermissionNames.API_Customer_Create, L("API_Customer_Create"));
            context.CreatePermission(PermissionNames.API_Customer_Delete, L("API_Customer_Delete"));
            context.CreatePermission(PermissionNames.API_Customer_Get, L("API_Customer_Get"));
            context.CreatePermission(PermissionNames.API_Customer_GetAll, L("API_Customer_GetAll"));
            context.CreatePermission(PermissionNames.API_Customer_Update, L("API_Customer_Update"));
            #endregion
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, XTOPMSConsts.LocalizationSourceName);
        }

    }
}
