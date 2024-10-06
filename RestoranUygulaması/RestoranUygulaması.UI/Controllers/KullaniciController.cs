using Microsoft.AspNetCore.Mvc;
using RestoranUygulaması.Business;
using RestoranUygulaması.Entities;
using RestoranUygulaması.UI.Models;

namespace RestoranUygulaması.UI.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IKullaniciServisi _kullaniciServisi;

        // IKullaniciServisi'nin constructor ile enjekte edilmesi
        public KullaniciController(IKullaniciServisi kullaniciServisi)
        {
            _kullaniciServisi = kullaniciServisi;
        }

        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(GirisYapViewModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            Kullanici kullanici = _kullaniciServisi.GirisYap(model.Ad, model.Sifre);

            if (kullanici != null)
            {
                return View("~/Views/Home/Index.cshtml");
            }

            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl(KayitOlViewModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            Kullanici kullanici = new Kullanici();
            kullanici.Ad = model.Ad;
            kullanici.Sifre = model.Sifre;

            _kullaniciServisi.KayitOl(kullanici);

            return View("~/Views/Home/Index.cshtml");
        }
    }
}
