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
    public class EfIlceDal : EfEntityRepositoryBase<BasvuruUygulamasiDbContext,Ilce>,IIlceDal
    {
        public EfIlceDal(BasvuruUygulamasiDbContext context) : base(context) { }

    }
}
