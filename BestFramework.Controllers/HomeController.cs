using Microsoft.AspNetCore.Mvc;

namespace BestFramework.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    { 
        [HttpGet("test")]
        public string Get()
        {
            return "test";
        } 
    }
}
