using System;
using Microsoft.AspNetCore.Mvc;

namespace UrlDecode.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelloController : ControllerBase {
        [HttpGet("{input}")]
        public string Upper(string input) {
            var output = Uri.UnescapeDataString(input);
            Console.WriteLine(output);
            return output.ToUpper();
        }
    }
}
