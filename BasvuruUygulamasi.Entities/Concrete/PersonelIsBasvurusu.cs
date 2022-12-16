using BasvuruUygulamasi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Entities.Concrete
{
    public class PersonelIsBasvurusu:IEntity
    {
        public long Id  { get; set; }

        public long PersonelId { get; set; }

        public DateTime BasvuruTarihi { get; set; }

        public long SehirId { get; set; }

        public bool SeyahatEngeliYok { get; set; }

        public string IsYeriAdi { get; set; }

        public string Pozisyon { get; set; }

        public string Aciklama { get; set; }

        public Personel Personel { get; set; }

        public Sehir Sehir { get; set; }
    }
}
