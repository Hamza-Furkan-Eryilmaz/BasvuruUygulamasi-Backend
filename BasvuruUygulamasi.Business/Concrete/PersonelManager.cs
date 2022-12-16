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
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void Add(Personel personel)
        {
            _personelDal.Add(personel);
        }

        public List<Personel> GetList()
        {
            return new List<Personel>(_personelDal.GetList());
        }

        

        public List<PersonelDto> GetPersonelDetails()
        {
            return new List<PersonelDto>(_personelDal.GetPersonelDetails());
        }
    }
}
