using BasvuruUygulamasi.Business.Abstract;
using BasvuruUygulamasi.DataAccess.Abstract;
using BasvuruUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Business.Concrete
{
    public class SehirManager : ISehirService
    {
        private readonly ISehirDal _sehirDal;

        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public void Add(Sehir sehir)
        {
            _sehirDal.Add(sehir);
        }

        public List<Sehir> GetAll()
        {
            return new List<Sehir>(_sehirDal.GetList());
        }
    }
}
