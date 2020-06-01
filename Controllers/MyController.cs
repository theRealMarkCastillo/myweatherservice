using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myweatherservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {

        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "HELLO WORLD!";
        }
    }
}
