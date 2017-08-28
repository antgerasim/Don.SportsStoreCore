using System.Threading.Tasks;
using Abp.Application.Services;
using Don.SportsStoreCore.Sessions.Dto;

namespace Don.SportsStoreCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
