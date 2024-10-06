using RestoranUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Business
{
    public interface ISiparisServisi
    {
        void SiparisOlustur(Guid kullaniciId, Yemek yemek);
        List<Siparis> KullaniciSiparisleri(Kullanici kullanici);
        void CancelOrder(int siparisId);
    }
}
