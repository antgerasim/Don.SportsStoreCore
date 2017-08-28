using Abp.Authorization;
using Don.SportsStoreCore.Authorization.Roles;
using Don.SportsStoreCore.Authorization.Users;

namespace Don.SportsStoreCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
