using BasvuruUygulamasi.Core.Entities;
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
    public class EfPersonelIsBasvurusuDal:EfEntityRepositoryBase<BasvuruUygulamasiDbContext,PersonelIsBasvurusu>, IPersonelIsBasvurusuDal
    {
        public EfPersonelIsBasvurusuDal(BasvuruUygulamasiDbContext context) : base(context) { }

        public List<PersonelIsBasvurusuDto> GetPersonelBasvuruDetails(Expression<Func<PersonelIsBasvurusuDto, bool>> filter = null)
        {
          
            
                var query = from pb in Context.PersonelIsBasvurulari                          
                            join sehir in Context.Sehirler on pb.SehirId equals sehir.Id
                            join personel in Context.Personeller on pb.PersonelId equals personel.Id
                            

                            select new PersonelIsBasvurusuDto()
                            {
                              
                                PersonelId=personel.Id,
                                SehirAdi = sehir.Adi,
                                BasvuruTarihi = pb.BasvuruTarihi,
                                IsYeriAdi = pb.IsYeriAdi,
                                Pozisyon = pb.Pozisyon,
                                Aciklama = pb.Aciklama,
                                SeyahatEngeliYok = pb.SeyahatEngeliYok
                            };
            return  filter == null
                ? query.ToList()
                : query.Where(filter).ToList();


        }
    }
}
