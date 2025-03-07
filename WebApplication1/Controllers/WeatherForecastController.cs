using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet("{firstName}/{lastName}")]
        public IActionResult GetData(string firstName, string lastName)
        {
            var currentTime = System.DateTime.Now;
            var formattedTime = currentTime.ToString("F"); // Full date/time pattern (long time)
            var fullName = $"{firstName} {lastName}";
            return Ok(new { fullName = fullName, formattedTime });
        }
    }
}
