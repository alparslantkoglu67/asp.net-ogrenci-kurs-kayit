using System.ComponentModel.DataAnnotations;

namespace efCoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; } = null!;
        public Kurs Kurs { get; set; } = null!;
        public int KursId { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}