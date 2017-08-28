using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.SportsStoreCore.MultiTenancy.Dto;

namespace Don.SportsStoreCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
