using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.SportsStoreCore.Roles.Dto;
using Don.SportsStoreCore.Users.Dto;

namespace Don.SportsStoreCore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}