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
                Current_DateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                GitHub_URL = "https://github.com/AlfredOdey/TheDriverDevHNGAPI"
            };

            return Ok(response);
        }
    }
}
