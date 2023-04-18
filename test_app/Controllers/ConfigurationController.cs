using Test_App.Models;
using Test_App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Test_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;
        public ConfigurationController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpPost]
        public IActionResult AddConfiguration([FromBody] JiraConfiguration configuration)
        {
            var result = _configurationService.AddConfiguration(configuration);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateConfiguration([FromBody] JiraConfiguration configuration)
        {
            var result = _configurationService.UpdateConfiguration(configuration);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetConfiguration(int id)
        {
            var result = _configurationService.GetConfiguration(id);
            return Ok(result);
        }
    }
}

using System.Threading.Tasks;
using Test_App.Models;
using Test_App.Services.Interfaces;

namespace Test_App.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public Task<JiraConfiguration> AddConfiguration(JiraConfiguration configuration)
        {
            //TODO: Add logic for adding configuration
            return Task.FromResult(configuration);
        }

        public Task<JiraConfiguration> UpdateConfiguration(JiraConfiguration configuration)
        {
            //TODO: Add logic for updating configuration
            return Task.FromResult(configuration);
        }

        public Task<JiraConfiguration> GetConfiguration(int id)
        {
            //TODO: Add logic for getting configuration
            return Task.FromResult(new JiraConfiguration());
        }
    }
}