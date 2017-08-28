using Abp.AutoMapper;
using Don.SportsStoreCore.Sessions.Dto;

namespace Don.SportsStoreCore.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}