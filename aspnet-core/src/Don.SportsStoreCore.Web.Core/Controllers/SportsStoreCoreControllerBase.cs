using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Don.SportsStoreCore.Controllers
{
    public abstract class SportsStoreCoreControllerBase: AbpController
    {
        protected SportsStoreCoreControllerBase()
        {
            LocalizationSourceName = SportsStoreCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}