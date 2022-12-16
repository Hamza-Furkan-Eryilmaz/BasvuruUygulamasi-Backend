using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Entities.Dtos
{
    public class PersonelIsBasvurusuDto
    {
        

        public long PersonelId { get; set; }

        public DateTime BasvuruTarihi { get; set; }

        public string SehirAdi { get; set; }

        public bool SeyahatEngeliYok { get; set; }

        public string IsYeriAdi { get; set; }

        public string Pozisyon { get; set; }

        public string Aciklama { get; set; }
    }
}
