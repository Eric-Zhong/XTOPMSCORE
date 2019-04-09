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


        private Role CreateSystemRole(string roleName)
        {
            var role = _context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == _tenantId && r.Name == roleName);
            if (role == null)
            {
                role = _context.Roles.Add(new Role(_tenantId, roleName, roleName) { IsStatic = true }).Entity;
                _context.SaveChanges();
            }
            return role;
        }


        private void CreateRolesAndUsers()
        {
            // Admin role
            var adminRole = CreateSystemRole(StaticRoleNames.Tenants.Admin);
            // Common user
            var userRole = CreateSystemRole(StaticRoleNames.Tenants.User);

            // XTOPMS Roles
            CreateSystemRole(StaticRoleNames.Tenants.Commercial);
            CreateSystemRole(StaticRoleNames.Tenants.Engineer);
            CreateSystemRole(StaticRoleNames.Tenants.Finance);
            CreateSystemRole(StaticRoleNames.Tenants.ProjectManager);
            CreateSystemRole(StaticRoleNames.Tenants.Sales);
            CreateSystemRole(StaticRoleNames.Tenants.Service);
            CreateSystemRole(StaticRoleNames.Tenants.SupplyChain);
            CreateSystemRole(StaticRoleNames.Tenants.Tender);


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

            CreateSomeUser(userRole);

        }


        // create some user for testing
        private void CreateSomeUser(Role userRole)
        {
            string[] users = new string[] {
                "Sales","Tender","PM","Engineer", "Designer", "SupplyChain", "Service", "Finance"
            };

            foreach(string user in users)
            {
                CreateSystemUser(_tenantId, userRole.Id, user);
            }
        }

        private void CreateSystemUser(int tenantId, int roleId, string username)
        {
            var adminUser = _context.Users.First(t => t.Id == 1);
            var user = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == tenantId && u.UserName == username);
            if (user == null)
            {
                user = new User
                {
                    TenantId = tenantId,
                    UserName = username,
                    Name = username,
                    Surname = username,
                    EmailAddress = username + "@xtopms.com",
                    // Add other default value
                    CreatorUserId = 1,
                    LastModifierUserId = 1,
                    Address = "N/A",
                    IdCard = "N/A",
                    // IsEmailConfirmed = false,
                    IsLockoutEnabled = false,
                    IsPhoneNumberConfirmed = false,
                    NormalizedUserName = "管理员",
                    NormalizedEmailAddress = "N/A",
                    Phone = "N/A",
                    Signature = "我很懒，什么都没写。"
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
