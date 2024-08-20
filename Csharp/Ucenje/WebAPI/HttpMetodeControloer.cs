using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
namespace WebAPI
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeControloer: ControllerBase
    {
        [HttpGet]
        public string Pozdravi()
        {
            return "hello";
        }

        [HttpPut]
        public IActionResult Put(Osobacs osoba)
        {
            if (ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            return StatusCode(StatusCodes.Status205ResetContent, osoba);
        }
    }
}
