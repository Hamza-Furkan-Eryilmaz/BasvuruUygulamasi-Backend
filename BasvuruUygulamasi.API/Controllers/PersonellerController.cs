using AutoMapper;
using BasvuruUygulamasi.API.Models;
using BasvuruUygulamasi.Business.Abstract;
using BasvuruUygulamasi.Entities.Concrete;
using BasvuruUygulamasi.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasvuruUygulamasi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonellerController : ControllerBase
    {
        private readonly IPersonelService _personelService;
        private readonly IMapper _mapper;


        public PersonellerController(IPersonelService personelService, IMapper mapper)
        {
            _personelService = personelService;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public IActionResult Add(PersonelCreateVM model)
        {
            Personel personel=_mapper.Map<Personel>(model);
           _personelService.Add(personel);

            return Ok();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _personelService.GetPersonelDetails();

            return Ok(result);
        }

       

        
    }
}
