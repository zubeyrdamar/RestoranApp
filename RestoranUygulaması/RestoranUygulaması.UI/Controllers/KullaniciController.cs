using Microsoft.AspNetCore.Mvc;
using RestoranUygulaması.UI.Models;

namespace RestoranUygulaması.UI.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(GirisYapViewModel model)
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
