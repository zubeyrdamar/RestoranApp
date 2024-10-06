using System.ComponentModel.DataAnnotations;

namespace RestoranUygulaması.UI.Models
{
    public class SiparisOlusturViewModel
    {
        [Required]
        public string Ad { get; set; }

        [Required]
        public string Fiyat { get; set; }

        [Required]
        public Guid KullaniciId { get; set; }
    }
}
