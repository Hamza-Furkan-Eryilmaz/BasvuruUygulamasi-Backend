using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Entities.Dtos
{
    public class PersonelDto
    {
        public long Id { get; set; }

        public string AdSoyad { get; set; }

        public string SehirAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Aciklama { get; set; }
    }
}
