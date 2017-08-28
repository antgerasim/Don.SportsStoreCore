using Abp.AspNetCore.Mvc.Authorization;
using Don.SportsStoreCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Don.SportsStoreCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SportsStoreCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}