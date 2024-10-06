using RestoranUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Business
{
    public interface IKullaniciServisi
    {
        Kullanici GirisYap(string ad, string sifre);
        void KayitOl(Kullanici kullanici);
    }
}
