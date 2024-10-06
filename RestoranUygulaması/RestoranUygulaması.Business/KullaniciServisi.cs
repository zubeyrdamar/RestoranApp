using RestoranUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Business
{
    public class KullaniciServisi : IKullaniciServisi
    {
        // Sahte kullanıcı listesi
        private static List<Kullanici> kullanicilar = new List<Kullanici>
        {
            new Kullanici { Id = Guid.NewGuid(), Ad = "admin", Sifre = "1234" },
        };

        // Kullanıcı girişini doğrulayan metod
        public Kullanici GirisYap(string ad, string sifre)
        {
            // Kullanıcıyı kullanıcı adı ve şifreye göre bul
            return kullanicilar.FirstOrDefault(u => u.Ad == ad && u.Sifre == sifre);
        }

        // Yeni bir kullanıcı ekleyen metod
        public void KayitOl(Kullanici kullanici)
        {
            // Kullanıcı listesini kontrol edip benzersiz kullanıcı adıyla kaydet
            if (kullanicilar.Any(u => u.Ad == kullanici.Ad))
            {
                throw new Exception("Bu kullanıcı adı zaten var.");
            }

            // Yeni kullanıcıyı ID ile ekle
            kullanici.Id = Guid.NewGuid();
            kullanicilar.Add(kullanici);
        }
    }
}
