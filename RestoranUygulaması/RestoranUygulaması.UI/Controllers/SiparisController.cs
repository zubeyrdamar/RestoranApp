using Microsoft.AspNetCore.Mvc;
using RestoranUygulaması.Business;
using RestoranUygulaması.Entities;
using RestoranUygulaması.UI.Models;

namespace RestoranUygulaması.UI.Controllers
{
    public class SiparisController : Controller
    {
        private readonly IKullaniciServisi _kullaniciServisi;
        private readonly ISiparisServisi _siparisServisi;

        public SiparisController(IKullaniciServisi kullaniciServisi, ISiparisServisi siparisServisi)
        {
            _kullaniciServisi = kullaniciServisi;
            _siparisServisi = siparisServisi;
        }

        public IActionResult Menu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SiparisEt(string Ad, decimal Fiyat)
        {
            Yemek yemek = new Yemek();
            yemek.Ad = Ad;
            yemek.Fiyat = Fiyat;
            
            _siparisServisi.SiparisOlustur(Guid.Parse(HttpContext.Session.GetString("KullaniciId")), yemek);

            ViewBag.Message = "Siparişiniz Alınmıştır";
            return View("~/Views/Siparis/Menu.cshtml");
        }

        public IActionResult Siparisler()
        {
            List<Siparis> siparisler = _siparisServisi.KullaniciSiparisleri(Guid.Parse(HttpContext.Session.GetString("KullaniciId")));
            return View(siparisler);
        }

        [HttpPost]
        public IActionResult SiparisİptalEt(int siparisId)
        {
            _siparisServisi.Siparisİptal(siparisId);
            List<Siparis> siparisler = _siparisServisi.KullaniciSiparisleri(Guid.Parse(HttpContext.Session.GetString("KullaniciId")));
            return View("~/Views/Siparis/Siparisler.cshtml", siparisler);
        }
    }
}
