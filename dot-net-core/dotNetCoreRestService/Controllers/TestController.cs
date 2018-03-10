using Microsoft.AspNetCore.Mvc;

namespace dotNetCoreRestService.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }
    }
}
