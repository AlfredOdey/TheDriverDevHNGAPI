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
                CurrentDate = DateTime.UtcNow.ToString("o"),
                GitHubURL = ""
            };

            return Ok(response);
        }
    }
}
