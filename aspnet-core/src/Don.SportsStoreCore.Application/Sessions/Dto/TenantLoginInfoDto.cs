using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Don.SportsStoreCore.MultiTenancy;

namespace Don.SportsStoreCore.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}