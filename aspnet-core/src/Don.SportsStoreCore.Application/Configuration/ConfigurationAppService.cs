using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Don.SportsStoreCore.Configuration.Dto;

namespace Don.SportsStoreCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SportsStoreCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
