using System.Collections.Generic;
using Don.SportsStoreCore.Roles.Dto;
using Don.SportsStoreCore.Users.Dto;

namespace Don.SportsStoreCore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}