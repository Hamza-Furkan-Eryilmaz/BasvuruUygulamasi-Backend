using BasvuruUygulamasi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Entities.Concrete
{
    public class Personel:IEntity
    {
        public long Id { get; set; }

        public string AdiSoyadi { get; set; }

        public long SehirId { get; set; }

        public long IlceId { get; set; }

        public string Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Aciklama { get; set; }

        public Sehir Sehir { get; set; }

        public Ilce Ilce { get; set; }

        public ICollection<PersonelIsBasvurusu> PersonelIsBasvurulari { get; set; }
    }
}
