using System.Collections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [HttpGet("GetList")]
        public IEnumerable<string> GetCarriersAsync()
        {
            return new string[] { "Demo 1", "Demo2" };
        }
    }
}
