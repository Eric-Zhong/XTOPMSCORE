using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Domain.Entities;
using Abp.Extensions;
using Abp.Organizations;
using XTOPMS.Utilities;

namespace XTOPMS.Authorization.Users
{
    public class User 
        : AbpUser<User>, 
        IXTOPMSEntity,
        IExtendableObject, 
        IMayHaveOrganizationUnit
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                EmployeeNumber = IdFactory.NewId().ToString()
            };
            user.SetNormalizedNames();
            return user;
        }


        // New property for XTOPMS
        [StringLength(50)]
        public string EmployeeNumber { get; set; }
        [StringLength(50)]
        public string IdCard { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Signature { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public string ExtensionData { get; set; }
        public long? OrganizationUnitId { get; set; }
        public string Code { get; set; }
        public string ErpId { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
    }
}
