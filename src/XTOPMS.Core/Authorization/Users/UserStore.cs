using System.Collections.Generic;
using System.Linq;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Linq;
using XTOPMS.Authorization.Roles;

namespace XTOPMS.Authorization.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
            IUnitOfWorkManager unitOfWorkManager, 
            IRepository<User, long> userRepository, 
            IRepository<Role> roleRepository, 
            IAsyncQueryableExecuter asyncQueryableExecuter, 
            IRepository<UserRole, long> userRoleRepository, 
            IRepository<UserLogin, long> userLoginRepository, 
            IRepository<UserClaim, long> userClaimRepository, 
            IRepository<UserPermissionSetting, long> userPermissionSettingRepository) 
            : base(
                  unitOfWorkManager, 
                  userRepository, 
                  roleRepository, 
                  asyncQueryableExecuter, 
                  userRoleRepository, 
                  userLoginRepository, 
                  userClaimRepository,
                  userPermissionSettingRepository)
        {
        }


        public List<User> QuickSearch(string key, int maxCount = 20)
        {
            var query = from m in UserRepository.GetAll()
                        where
                            (m.Name ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                            (m.FullName ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                            (m.EmailAddress ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                            (m.EmployeeNumber ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                            (m.Title ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase)
                        orderby m.Name
                        select m;
            return query.Take(maxCount).ToList();
        }
    }
}
