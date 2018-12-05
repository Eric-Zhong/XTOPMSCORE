using Microsoft.AspNetCore.Antiforgery;
using XTOPMS.Controllers;

namespace XTOPMS.Web.Host.Controllers
{
    public class AntiForgeryController : XTOPMSControllerBase
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
