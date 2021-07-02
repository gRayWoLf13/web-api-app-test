using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_api_app_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet("sayhello")]
        [Produces("application/json")]
        public ActionResult<string> SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return NotFound();
            return $"Hello {name}!";
        }
    }
}