using BasvuruUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Business.Abstract
{
    public interface ISehirService
    {
        List<Sehir> GetAll();

        void Add(Sehir sehir);
    }
}
