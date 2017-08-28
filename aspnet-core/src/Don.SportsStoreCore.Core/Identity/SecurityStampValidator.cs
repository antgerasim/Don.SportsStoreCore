using Abp.Authorization;
using Don.SportsStoreCore.Authorization.Roles;
using Don.SportsStoreCore.Authorization.Users;
using Don.SportsStoreCore.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace Don.SportsStoreCore.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}