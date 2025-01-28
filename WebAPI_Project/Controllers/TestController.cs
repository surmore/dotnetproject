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
        [HttpGet]

        public string Hello()
        {
            return " Hello Rajashree Bhamare";
        }

        public string FromGitHub()
        {
    return "Bye From GitHub";
        }

        public string stashFinal5()
{
    return " Hello stashFinal5";
}


        public string stashFinal()
        {
            return " Hello stashFinal";
        }

        public string pop5()
{
    return " Hello stashFinal";
}
    }
}
