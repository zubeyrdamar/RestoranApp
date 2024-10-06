using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Entities
{
    public class Siparis
    {
        public int Id { get; set; }
        public Kullanici kullanici { get; set; }
        public List<Yemek> SiparisEdilenYemekler { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public bool IptalDurumu { get; set; }

        public Siparis()
        {
            SiparisEdilenYemekler = new List<Yemek>();
            IptalDurumu = false;
        }
    }
}
