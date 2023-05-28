using APBD_6.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_6.Controllers
{
    [ApiController]
    [Route("api")]
    public class NAZWA_Controller : Controller
    {
        private readonly IAPBDService _service;

        public NAZWA_Controller(IAPBDService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("orders")]
        public async Task<IActionResult> GetHello(){
          var value = await _service.GetHello();


            return Ok(value);
        }

    }
}
