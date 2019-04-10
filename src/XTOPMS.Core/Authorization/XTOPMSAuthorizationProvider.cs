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


            #region Customer Permissions
            // Customer API
            context.CreatePermission(PermissionNames.Pages_Customer_Index, L("Pages_Customer_Index"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Customer_Create, L("API_Customer_Create"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Customer_Delete, L("API_Customer_Delete"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Customer_Get, L("API_Customer_Get"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Customer_GetAll, L("API_Customer_GetAll"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Customer_Update, L("API_Customer_Update"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion


            #region Opportunity Permissions
            // Customer API
            context.CreatePermission(PermissionNames.Pages_Opportunity_Index, L("Pages_Opportunity_Index"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Opportunity_Create, L("API_Opportunity_Create"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Opportunity_Get, L("API_Opportunity_Get"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Opportunity_GetAll, L("API_Opportunity_GetAll"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Opportunity_Update, L("API_Opportunity_Update"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.API_Opportunity_Delete, L("API_Opportunity_Delete"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, XTOPMSConsts.LocalizationSourceName);
        }

    }
}
