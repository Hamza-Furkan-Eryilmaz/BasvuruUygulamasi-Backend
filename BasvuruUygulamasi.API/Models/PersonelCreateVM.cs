namespace BasvuruUygulamasi.API.Models
{
    public class PersonelCreateVM
    {
        public string AdiSoyadi { get; set; }

        public long SehirId { get; set; }

        public long IlceId { get; set; }

        public string Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Aciklama { get; set; }
    }
}
