using Abp.Authorization;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;

namespace XTOPMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
