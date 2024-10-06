using System.ComponentModel.DataAnnotations;

namespace RestoranUygulaması.UI.Models
{
    public class KayitOlViewModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Ad { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        [MaxLength(30)]
        public string Sifre { get; set; }
    }
}
