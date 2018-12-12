using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using XTOPMS.Authorization;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;

namespace XTOPMS.EntityFrameworkCore.Seed.Tenants
{
    public class TenantRoleAndUserBuilder
    {
        private readonly XTOPMSDbContext _context;
        private readonly int _tenantId;

        public TenantRoleAndUserBuilder(XTOPMSDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            // Admin role
            var adminRole = _context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Admin);
            if (adminRole == null)
            {
                adminRole = _context.Roles.Add(new Role(_tenantId, StaticRoleNames.Tenants.Admin, StaticRoleNames.Tenants.Admin) { IsStatic = true }).Entity;
                _context.SaveChanges();
            }

            // Grant all permissions to admin role
            var grantedPermissions = _context.Permissions.IgnoreQueryFilters()
                .OfType<RolePermissionSetting>()
                .Where(p => p.TenantId == _tenantId && p.RoleId == adminRole.Id)
                .Select(p => p.Name)
                .ToList();

            var permissions = PermissionFinder
                .GetAllPermissions(new XTOPMSAuthorizationProvider())
                .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant) &&
                            !grantedPermissions.Contains(p.Name))
                .ToList();

            if (permissions.Any())
            {
                _context.Permissions.AddRange(
                    permissions.Select(permission => new RolePermissionSetting
                    {
                        TenantId = _tenantId,
                        Name = permission.Name,
                        IsGranted = true,
                        RoleId = adminRole.Id
                    })
                );
                _context.SaveChanges();
            }

            // Admin user
            var adminUser = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == _tenantId && u.UserName == AbpUserBase.AdminUserName);
            if (adminUser == null)
            {
                adminUser = User.CreateTenantAdminUser(_tenantId, "admin@xtopms.com");
                adminUser.Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(adminUser, "123qwe");
                adminUser.IsEmailConfirmed = true;
                adminUser.IsActive = true;

                _context.Users.Add(adminUser);
                _context.SaveChanges();

                // Assign Admin role to admin user
                _context.UserRoles.Add(new UserRole(_tenantId, adminUser.Id, adminRole.Id));
                _context.SaveChanges();
            }


            // common user
            var userRole = _context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.User);
            if (userRole == null)
            {
                userRole = _context.Roles.Add(new Role(_tenantId, StaticRoleNames.Tenants.User, StaticRoleNames.Tenants.User) { IsStatic = true }).Entity;
                _context.SaveChanges();
            }


            CreateSomeUser(userRole);

        }


        // create some user for testing
        private void CreateSomeUser(Role userRole)
        {
            string[] users = new string[] {
                "Sales","Tender","PM","PE", "Designer", "CS", "QA"
            };

            foreach(string user in users)
            {
                CreateSystemUser(_tenantId, userRole.Id, user);
            }
        }

        private void CreateSystemUser(int tenantId, int roleId, string username)
        {
            var user = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == tenantId && u.UserName == username);
            if (user == null)
            {
                user = new User
                {
                    TenantId = tenantId,
                    UserName = username,
                    Name = username,
                    Surname = username,
                    EmailAddress = username + "@xtopms.com"
                };
                user.Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(user, "123qwe");
                user.IsEmailConfirmed = true;
                user.IsActive = true;

                user.SetNormalizedNames();

                _context.Users.Add(user);
                _context.SaveChanges();

                // assign user role
                _context.UserRoles.Add(new UserRole
                {
                    TenantId = tenantId,
                    RoleId = roleId,
                    UserId = user.Id
                });
                _context.SaveChanges();

            }
        }
    }
}
