using Don.SportsStoreCore.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Don.SportsStoreCore.Web.Host.Controllers
{
    public class AntiForgeryController : SportsStoreCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}