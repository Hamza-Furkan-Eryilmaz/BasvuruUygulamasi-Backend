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
    public class IlceManager : IIlceService
    {
        private readonly IIlceDal _ilceDal;

        public IlceManager(IIlceDal ilceDal)
        {
            _ilceDal = ilceDal;
        }

        public void Add(Ilce ilce)
        {
            _ilceDal.Add(ilce);
        }
       

        public ICollection<Ilce> GetBySehirId(int sehirId)
        {
            return new List<Ilce>(_ilceDal.GetList(i=>i.SehirId== sehirId));
        }
    }
}
