using BasvuruUygulamasi.Core.Repos;
using BasvuruUygulamasi.DataAccess.Abstract;
using BasvuruUygulamasi.DataAccess.Concrete.Context;
using BasvuruUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.DataAccess.Concrete.EntityFramework
{
    public class EfSehirDal : EfEntityRepositoryBase<BasvuruUygulamasiDbContext, Sehir>, ISehirDal
    {
        public EfSehirDal(BasvuruUygulamasiDbContext context) : base(context){}
    }
}
