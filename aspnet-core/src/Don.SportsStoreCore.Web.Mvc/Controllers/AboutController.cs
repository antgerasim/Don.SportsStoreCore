using Don.SportsStoreCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Don.SportsStoreCore.Web.Controllers
{
    public class AboutController : SportsStoreCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}