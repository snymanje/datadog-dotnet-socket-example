using Microsoft.AspNetCore.Mvc;

namespace UBIDotNetImage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public string GetHelloWorld()
        {
            return "Hello, World!";
        }
    }
}
