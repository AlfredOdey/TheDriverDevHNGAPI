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
                email = "alfredmodey@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/AlfredOdey/TheDriverDevHNGAPI"
            };

            return Ok(response);
        }
    }
}
