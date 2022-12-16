using BasvuruUygulamasi.Entities.Concrete;
using BasvuruUygulamasi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Business.Abstract
{
    public interface IPersonelIsBasvurusuService
    {
        List<PersonelIsBasvurusu> GetAll();

        void Add(PersonelIsBasvurusu personelIsBasvurusu);

        List<PersonelIsBasvurusuDto> GetByPersonelId(int personelId);
    }
}
