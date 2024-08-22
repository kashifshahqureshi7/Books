using Abp.Application.Services;
using SchoolManegment.MultiTenancy.Dto;

namespace SchoolManegment.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

