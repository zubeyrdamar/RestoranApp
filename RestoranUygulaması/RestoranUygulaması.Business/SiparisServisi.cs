using RestoranUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Business
{
    public class SiparisServisi : ISiparisServisi
    {
        private static List<Siparis> siparisler = new List<Siparis>();

        public void SiparisOlustur(Kullanici kullanici, List<Yemek> yemekler)
        {
            var siparis = new Siparis
            {
                Id = siparisler.Count + 1,
                kullanici = kullanici,
                SiparisEdilenYemekler = yemekler,
                SiparisTarihi = DateTime.Now
            };

            siparisler.Add(siparis);
        }

        public List<Siparis> KullaniciSiparisleri(Kullanici kullanici)
        {
            return siparisler.Where(o => o.kullanici.Id == kullanici.Id).ToList();
        }

        public void CancelOrder(int siparisId)
        {
            var siparis = siparisler.FirstOrDefault(o => o.Id == siparisId);
            if (siparis != null)
            {
                siparis.IptalDurumu = true;
            }
        }
    }
}
