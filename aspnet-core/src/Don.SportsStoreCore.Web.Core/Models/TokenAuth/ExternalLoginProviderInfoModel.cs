using Abp.AutoMapper;
using Don.SportsStoreCore.Authentication.External;

namespace Don.SportsStoreCore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
