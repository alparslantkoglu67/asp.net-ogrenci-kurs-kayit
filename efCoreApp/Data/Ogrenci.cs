using System.ComponentModel.DataAnnotations;

namespace efCoreApp.Data
{
    public class Ogrenci{
        [Key]
        public int OgrenciId { get; set; }//id==>primary Key
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? AdSoyad { 
            get
            {
                return this.OgrenciAd + " " +this.OgrenciSoyad;
            }
        }
        public string? Telefon { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

    }
}