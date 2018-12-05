using Abp.Application.Services;
using Abp.Application.Services.Dto;
using XTOPMS.MultiTenancy.Dto;

namespace XTOPMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
