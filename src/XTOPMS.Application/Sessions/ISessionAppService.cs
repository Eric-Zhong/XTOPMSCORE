using System.Threading.Tasks;
using Abp.Application.Services;
using XTOPMS.Sessions.Dto;

namespace XTOPMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
