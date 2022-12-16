using AutoMapper;
using BasvuruUygulamasi.Entities.Concrete;

namespace BasvuruUygulamasi.API.Models
{
    public class AutoMapperProfiler:Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<Sehir, SehirVM>().ReverseMap();
            CreateMap<Ilce, IlceVM>().ReverseMap();
            CreateMap<PersonelIsBasvurusu, PersonelIsBasvurusuVM>().ReverseMap();
            CreateMap<Personel,PersonelCreateVM>().ReverseMap();

        }
    }
}
