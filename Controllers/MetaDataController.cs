using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheDriverDevHNGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaDataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            var response = new
            {
                Email = "alfredmodey@gmail.com",
                Current_Date = DateTime.UtcNow.ToString("o"),
                Github_URL = ""
            };

            return Ok(response);
        }
    }
}
