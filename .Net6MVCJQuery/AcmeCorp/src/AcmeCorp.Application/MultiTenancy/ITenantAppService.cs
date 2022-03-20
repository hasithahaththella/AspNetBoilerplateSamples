using Abp.Application.Services;
using AcmeCorp.MultiTenancy.Dto;

namespace AcmeCorp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

