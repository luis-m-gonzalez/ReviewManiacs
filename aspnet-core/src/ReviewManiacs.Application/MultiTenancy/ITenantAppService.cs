using Abp.Application.Services;
using ReviewManiacs.MultiTenancy.Dto;

namespace ReviewManiacs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

