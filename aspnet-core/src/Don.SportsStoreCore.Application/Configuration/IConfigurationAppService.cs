using System.Threading.Tasks;
using Don.SportsStoreCore.Configuration.Dto;

namespace Don.SportsStoreCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}