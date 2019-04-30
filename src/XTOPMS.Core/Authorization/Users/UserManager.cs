using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Abp.Runtime.Caching;
using XTOPMS.Authorization.Roles;

namespace XTOPMS.Authorization.Users
{
    public class UserManager : AbpUserManager<Role, User>
    {
        public UserManager(
            RoleManager roleManager,
            UserStore store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<User> passwordHasher, 
            IEnumerable<IUserValidator<User>> userValidators, 
            IEnumerable<IPasswordValidator<User>> passwordValidators,
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<User>> logger, 
            IPermissionManager permissionManager, 
            IUnitOfWorkManager unitOfWorkManager, 
            ICacheManager cacheManager, 
            IRepository<OrganizationUnit, long> organizationUnitRepository, 
            IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository, 
            IOrganizationUnitSettings organizationUnitSettings, 
            ISettingManager settingManager)
            : base(
                roleManager, 
                store, 
                optionsAccessor, 
                passwordHasher, 
                userValidators, 
                passwordValidators, 
                keyNormalizer, 
                errors, 
                services, 
                logger, 
                permissionManager, 
                unitOfWorkManager, 
                cacheManager,
                organizationUnitRepository, 
                userOrganizationUnitRepository, 
                organizationUnitSettings, 
                settingManager)
        {
        }

        public List<User> QuickSearch(string key, int count = 20)
        {
            return this.Users.Where(t =>
                (t.Name ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.EmailAddress ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.FullName ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.Surname ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.EmployeeNumber ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase)
            ).OrderBy(t => t.Name).Take(count).ToList();
        }

    }
}
