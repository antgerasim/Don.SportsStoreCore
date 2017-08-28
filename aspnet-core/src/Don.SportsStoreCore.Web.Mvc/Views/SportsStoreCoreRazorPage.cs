using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Don.SportsStoreCore.Web.Views
{
    public abstract class SportsStoreCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SportsStoreCoreRazorPage()
        {
            LocalizationSourceName = SportsStoreCoreConsts.LocalizationSourceName;
        }
    }
}
