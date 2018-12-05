using System.Threading.Tasks;
using Abp.Application.Services;
using XTOPMS.Authorization.Accounts.Dto;

namespace XTOPMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
