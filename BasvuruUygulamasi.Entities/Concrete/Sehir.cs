using BasvuruUygulamasi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Entities.Concrete
{
    public class Sehir:IEntity
    {
        
        public long Id { get; set; }

        public string Adi { get; set; }

        public ICollection<Ilce> Ilceler { get; set; }

        public ICollection<Personel> Personeller { get; set; }

        public ICollection<PersonelIsBasvurusu> PersonelIsBasvurulari { get; set; }
    }
}
