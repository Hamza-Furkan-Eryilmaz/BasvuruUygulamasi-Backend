using BasvuruUygulamasi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasvuruUygulamasi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlcelerController : ControllerBase
    {
        private readonly IIlceService _iilcelerService;

        public IlcelerController(IIlceService iilcelerService)
        {
            _iilcelerService = iilcelerService;
        }

        [HttpGet("GetBySehirId")]
        public IActionResult GetBySehirId(int sehirId) 
        {
            var result = _iilcelerService.GetBySehirId(sehirId).ToList();

            return Ok(result);
        }
    }
}
