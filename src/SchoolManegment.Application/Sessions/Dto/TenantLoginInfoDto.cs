using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SchoolManegment.MultiTenancy;

namespace SchoolManegment.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
