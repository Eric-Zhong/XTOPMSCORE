using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.Localization;
using Abp.Runtime.Session;
using XTOPMS.Authorization;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;
using XTOPMS.Roles.Dto;
using XTOPMS.Users.Dto;
using XTOPMS.Dto;

namespace XTOPMS.Users
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserAppService : 
        AsyncCrudAppService<User, UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
        , IUserAppService
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IRepository<Role> _roleRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(
            IRepository<User, long> repository,
            UserManager userManager,
            RoleManager roleManager,
            IRepository<Role> roleRepository,
            IPasswordHasher<User> passwordHasher,
            IPermissionManager permissionManager)
            : base(repository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;
            _permissionManager = permissionManager;
        }

        public override async Task<UserDto> Create(CreateUserDto input)
        {
            CheckCreatePermission();

            var user = ObjectMapper.Map<User>(input);

            user.TenantId = AbpSession.TenantId;
            user.IsEmailConfirmed = true;

            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);

            CheckErrors(await _userManager.CreateAsync(user, input.Password));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
            }

            CurrentUnitOfWork.SaveChanges();

            return MapToEntityDto(user);
        }

        public override async Task<UserDto> Update(UserDto input)
        {
            CheckUpdatePermission();

            var user = await _userManager.GetUserByIdAsync(input.Id);

            MapToEntity(input, user);

            CheckErrors(await _userManager.UpdateAsync(user));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
            }

            return await Get(input);
        }

        public override async Task Delete(EntityDto<long> input)
        {
            var user = await _userManager.GetUserByIdAsync(input.Id);
            await _userManager.DeleteAsync(user);
        }

        public async Task<ListResultDto<RoleDto>> GetRoles()
        {
            var roles = await _roleRepository.GetAllListAsync();
            return new ListResultDto<RoleDto>(ObjectMapper.Map<List<RoleDto>>(roles));
        }

        public async Task ChangeLanguage(ChangeUserLanguageDto input)
        {
            await SettingManager.ChangeSettingForUserAsync(
                AbpSession.ToUserIdentifier(),
                LocalizationSettingNames.DefaultLanguage,
                input.LanguageName
            );
        }

        protected override User MapToEntity(CreateUserDto createInput)
        {
            var user = ObjectMapper.Map<User>(createInput);
            user.SetNormalizedNames();
            return user;
        }

        protected override void MapToEntity(UserDto updateInput, User entity)
        {
            ObjectMapper.Map(updateInput, entity);
            entity.SetNormalizedNames();
        }

        protected override UserDto MapToEntityDto(User entity)
        {
            var roles = _roleManager.Roles.Where(r => entity.Roles.Any(ur => ur.RoleId == r.Id)).Select(r => r.NormalizedName);
            var userDto = base.MapToEntityDto(entity);
            userDto.RoleNames = roles.ToArray();
            return userDto;
        }

        protected override IQueryable<User> CreateFilteredQuery(PagedResultRequestDto input)
        {
            return Repository.GetAllIncluding(x => x.Roles);
        }

        protected override async Task<User> GetEntityByIdAsync(long id)
        {
            var user = await Repository.GetAllIncluding(x => x.Roles).FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                throw new EntityNotFoundException(typeof(User), id);
            }

            return user;
        }

        protected override IQueryable<User> ApplySorting(IQueryable<User> query, PagedResultRequestDto input)
        {
            return query.OrderBy(r => r.UserName);
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        /// <summary>
        /// Quick search the user.
        /// </summary>
        /// <returns>The search.</returns>
        /// <param name="inputDto">Input dto.</param>
        public async Task<List<UserDto>> QuickSearch(QuickSearchInputDto input)
        {
            string key = input.Value; 
            int count = input.Count;

            var list = await Repository.GetAll().Where(t =>
                (t.Name ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.UserName ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                // 因为邮箱中有域名，查询起来体验不好，没用的数据都查出来了
                // (t.EmailAddress ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                // (t.FullName ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                // (t.Surname ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase) ||
                (t.EmployeeNumber ?? "").Contains(key, System.StringComparison.OrdinalIgnoreCase)
            ).OrderBy(t => t.Name).Take(count).ToListAsync();

            List<UserDto> output = ObjectMapper.Map<List<UserDto>>(list);
            return output;
        }
    }
}
