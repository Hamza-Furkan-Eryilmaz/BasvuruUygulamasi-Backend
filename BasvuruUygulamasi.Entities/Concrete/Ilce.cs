using BasvuruUygulamasi.Core.Entities;

namespace BasvuruUygulamasi.Entities.Concrete
{
    public class Ilce:IEntity
    {
        
        public long Id { get; set; }

        public long SehirId { get; set; }

        public string Adi { get; set; }

        public Sehir Sehir { get; set; }

        public ICollection<Personel> Personeller { get; set; }
    }
}