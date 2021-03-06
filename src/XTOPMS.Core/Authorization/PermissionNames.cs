﻿namespace XTOPMS.Authorization
{
    public static class PermissionNames
    {
        // Pages
        public const string Pages_Tenants = "Pages.Tenants";
        public const string Pages_Users = "Pages.Users";
        public const string Pages_Roles = "Pages.Roles";

        #region Customer
        public const string Pages_Customer_Index = "Pages.Customer.Index";
        public const string API_Customer_Get = "API.Customer.Get";
        public const string API_Customer_GetAll = "API.Customer.GetAll";
        public const string API_Customer_Create = "API.Customer.Create";
        public const string API_Customer_Update = "API.Customer.Update";
        public const string API_Customer_Delete = "API.Customer.Delete";
        #endregion

        #region Opportunity
        public const string Pages_Opportunity_Index = "Pages.Opportunity.Index";
        public const string API_Opportunity_Get = "API.Opportunity.Get";
        public const string API_Opportunity_GetAll = "API.Opportunity.GetAll";
        public const string API_Opportunity_Create = "API.Opportunity.Create";
        public const string API_Opportunity_Update = "API.Opportunity.Update";
        public const string API_Opportunity_Delete = "API.Opportunity.Delete";
        #endregion

    }
}
