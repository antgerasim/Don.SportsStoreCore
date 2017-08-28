using Abp.AspNetCore.Mvc.ViewComponents;

namespace Don.SportsStoreCore.Web.Views
{
    public abstract class SportsStoreCoreViewComponent : AbpViewComponent
    {
        protected SportsStoreCoreViewComponent()
        {
            LocalizationSourceName = SportsStoreCoreConsts.LocalizationSourceName;
        }
    }
}