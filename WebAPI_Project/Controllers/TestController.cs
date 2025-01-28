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
            return " Hello World to DotNet Heaven rajashree ";
        }

        [HttpGet]
        public string Welcome()
        {
            return " Welcome to the World of DotNet";
        }
        
    }
}
