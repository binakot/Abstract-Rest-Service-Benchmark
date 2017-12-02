using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCoreRestService.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/test
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Hello, World!"};
        }
    }
}
