using Abp.Application.Services;
using Abp.Application.Services.Dto;
using bysj.MultiTenancy.Dto;

namespace bysj.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
