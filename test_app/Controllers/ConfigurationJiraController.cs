using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_App.Models;

namespace Test_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationJiraController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetConfigurationDetails()
        {
            //Get Configuration Details from database
            ConfigurationData configData = new ConfigurationData();
            try
            {
                //Process the data
                return Ok(configData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateConfigurationDetails(ConfigurationData configData)
        {
            try
            {
                //Update Configuration Details into database
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}