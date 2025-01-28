using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Project.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string GetHello()
        {
            return " Hello World ! ";
        }
    }
}
