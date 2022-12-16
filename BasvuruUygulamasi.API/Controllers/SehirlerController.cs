using AutoMapper;
using BasvuruUygulamasi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BasvuruUygulamasi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SehirlerController : ControllerBase
    {
        private readonly ISehirService _sehirService;
        

        public SehirlerController(ISehirService sehirService)
        {
            _sehirService = sehirService;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result=_sehirService.GetAll().ToList();
            

            return Ok(result);
        }
    }
}
