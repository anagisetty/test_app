using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace test_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {        
        private IConfiguration _configuration;
        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetGithubConfiguration()
        {
            var config = new {
                Name = _configuration["GitHub:Name"],
                Email = _configuration["GitHub:Email"],
                Username = _configuration["GitHub:Username"],
                Password = _configuration["GitHub:Password"],
                Repository = _configuration["GitHub:Repository"]
            };

            return Ok(config);
        }
    }
}