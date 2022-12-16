using AutoMapper;
using BasvuruUygulamasi.API.Models;
using BasvuruUygulamasi.Business.Abstract;
using BasvuruUygulamasi.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasvuruUygulamasi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelIsBasvurulariController : ControllerBase
    {
        private readonly IPersonelIsBasvurusuService _personelIsBasvurusuService;
        private readonly IMapper _mapper;

        public PersonelIsBasvurulariController(IPersonelIsBasvurusuService personelIsBasvurusuService, IMapper mapper)
        {
            _personelIsBasvurusuService = personelIsBasvurusuService;
            _mapper = mapper;
        }

        [HttpGet("GetByPersonelId")]
        public IActionResult GetByPersonelId(int personelId) 
        {
            var result = _personelIsBasvurusuService.GetByPersonelId(personelId);

            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(PersonelIsBasvurusuVM model)
        {
            PersonelIsBasvurusu basvuru = _mapper.Map<PersonelIsBasvurusu>(model);

            _personelIsBasvurusuService.Add(basvuru);

            return Ok();
        }
    }
}
