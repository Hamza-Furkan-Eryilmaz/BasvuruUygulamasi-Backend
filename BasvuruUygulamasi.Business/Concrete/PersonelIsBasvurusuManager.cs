using BasvuruUygulamasi.Business.Abstract;
using BasvuruUygulamasi.DataAccess.Abstract;
using BasvuruUygulamasi.Entities.Concrete;
using BasvuruUygulamasi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Business.Concrete
{
    public class PersonelIsBasvurusuManager : IPersonelIsBasvurusuService
    {
        private readonly IPersonelIsBasvurusuDal _personelIsBasvurusuDal;

        public PersonelIsBasvurusuManager(IPersonelIsBasvurusuDal personelIsBasvurusuDal)
        {
            _personelIsBasvurusuDal = personelIsBasvurusuDal;
        }

        public void Add(PersonelIsBasvurusu personelIsBasvurusu)
        {

            _personelIsBasvurusuDal.Add(personelIsBasvurusu);
        }

        public List<PersonelIsBasvurusu> GetAll()
        {
            return new List<PersonelIsBasvurusu>(_personelIsBasvurusuDal.GetList());
        }

        public List<PersonelIsBasvurusuDto> GetByPersonelId(int personelId)
        {
            return new List<PersonelIsBasvurusuDto>(_personelIsBasvurusuDal.GetPersonelBasvuruDetails(p=>p.PersonelId==personelId));
        }
    }
}
