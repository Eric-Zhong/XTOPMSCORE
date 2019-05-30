using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Identity;
using XTOPMS.Dto;
using XTOPMS.Roles.Dto;
using XTOPMS.Users.Dto;

namespace XTOPMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);
        Task<List<UserDto>> QuickSearch(QuickSearchInputDto input);
    }
}
