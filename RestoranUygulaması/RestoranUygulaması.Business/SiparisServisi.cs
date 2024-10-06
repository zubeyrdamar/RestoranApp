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

        public void SiparisOlustur(Guid kullaniciId, Yemek yemek)
        {
            var siparis = new Siparis
            {
                Id = siparisler.Count + 1,
                KullaniciId = kullaniciId,
                SiparisEdilenYemek = yemek,
                SiparisTarihi = DateTime.Now
            };

            siparisler.Add(siparis);
        }

        public List<Siparis> KullaniciSiparisleri(Guid kullaniciId)
        {
            return siparisler.Where(o => o.KullaniciId == kullaniciId).ToList();
        }

        public void Siparisİptal(int siparisId)
        {
            var siparis = siparisler.FirstOrDefault(o => o.Id == siparisId);
            if (siparis != null)
            {
                siparis.IptalDurumu = true;
            }
        }
    }
}
