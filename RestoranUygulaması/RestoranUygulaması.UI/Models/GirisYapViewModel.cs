using System.ComponentModel.DataAnnotations;

namespace RestoranUygulaması.UI.Models
{
    public class GirisYapViewModel
    {
        [Required]
        public string Ad { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}
