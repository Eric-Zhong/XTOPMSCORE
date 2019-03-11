using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;

namespace XTOPMS.Organizations.Dto
{
    public interface IOrganizationUnitAppService : IApplicationService
    {
        Task<ListResultDto<OrganizationUnitDto>> GetOrganizationUnits();

        Task<PagedResultDto<OrganizationUnitUserListDto>> GetOrganizationUnitUsers(GetOrganizationUnitUsersInput input);

        Task<OrganizationUnitDto> CreateOrganizationUnit(CreateOrganizationUnitInput input);

        Task<OrganizationUnitDto> UpdateOrganizationUnit(UpdateOrganizationUnitInput input);

        Task<OrganizationUnitDto> MoveOrganizationUnit(MoveOrganizationUnitInput input);

        Task DeleteOrganizationUnit(long input);

        Task AddUserToOrganizationUnit(UserToOrganizationUnitInput input);
        
        Task RemoveUserFromOrganizationUnit(UserToOrganizationUnitInput input);

        Task<bool> IsInOrganizationUnit(UserToOrganizationUnitInput input);

        UserOrganizationUnit GetUserOrganizationUnit();

        UserOrganizationUnit GetUserOrganizationUnitByUserid(string userid);

        Task<OrganizationUnitTreeDto> GetOrganizationUnitsTree();

    }
}
