using BasvuruUygulamasi.Core.Repos;
using BasvuruUygulamasi.Entities.Concrete;
using BasvuruUygulamasi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.DataAccess.Abstract
{
    public interface IPersonelDal:IEntityRepository<Personel>
    {
        List<PersonelDto> GetPersonelDetails(Expression<Func<PersonelDto, bool>> filter = null);
    }
}
