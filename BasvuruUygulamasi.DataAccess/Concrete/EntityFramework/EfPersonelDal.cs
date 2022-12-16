using BasvuruUygulamasi.Core.Repos;
using BasvuruUygulamasi.DataAccess.Abstract;
using BasvuruUygulamasi.DataAccess.Concrete.Context;
using BasvuruUygulamasi.Entities.Concrete;
using BasvuruUygulamasi.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<BasvuruUygulamasiDbContext, Personel>, IPersonelDal
    {
        public EfPersonelDal(BasvuruUygulamasiDbContext context) : base(context)
        {
        }

        public List<PersonelDto> GetPersonelDetails(Expression<Func<PersonelDto, bool>> filter = null)
        {
            var query = from personel in Context.Personeller
                        join sehir in Context.Sehirler on personel.SehirId equals sehir.Id
                        join ilce in Context.Ilceler on personel.IlceId equals ilce.Id

                        select new PersonelDto()
                        {
                            Id = personel.Id,
                            SehirAdi = sehir.Adi,
                            IlceAdi = ilce.Adi,
                            AdSoyad = personel.AdiSoyadi,
                            Cinsiyet = personel.Cinsiyet,
                            DogumTarihi = personel.DogumTarihi,
                            Aciklama = personel.Aciklama
                        };
            return query.ToList();
        }
    }
}
