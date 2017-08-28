using System.Collections.Generic;
using System.Linq;
using Don.SportsStoreCore.Roles.Dto;
using Don.SportsStoreCore.Users.Dto;

namespace Don.SportsStoreCore.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}