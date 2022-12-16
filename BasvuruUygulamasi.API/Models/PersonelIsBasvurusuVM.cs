namespace BasvuruUygulamasi.API.Models
{
    public class PersonelIsBasvurusuVM
    {
        public long PersonelId { get; set; }

        public DateTime BasvuruTarihi { get; set; }

        public long SehirId { get; set; }

        public bool SeyahatEngeliYok { get; set; }

        public string IsYeriAdi { get; set; }

        public string Pozisyon { get; set; }

        public string Aciklama { get; set; }
    }
}
