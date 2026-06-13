using Microsoft.AspNetCore.Mvc;

namespace GithubActionDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from GitHub actions";
        }
    }


}