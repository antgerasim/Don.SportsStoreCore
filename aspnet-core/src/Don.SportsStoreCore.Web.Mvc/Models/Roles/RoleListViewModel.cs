using System.Collections.Generic;
using Don.SportsStoreCore.Roles.Dto;

namespace Don.SportsStoreCore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
