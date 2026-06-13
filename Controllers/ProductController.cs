using Microsoft.AspNetCore.Mvc;


namespace ProductController.Controllers
{

    [ApiController]
    [Route("[api/Controller]")]

    public class ProductController : ControllerBase
    {
        [HttpGet("getproduct")]
        public string getProductDetails()
        {
            return "Banana, Apples";
        }
    }
    
}