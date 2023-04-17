using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_App.Configuration;

namespace Test_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetJiraConfiguration()
        {
            try
            {
                var jiraConfiguration = Jira.GetConfiguration();
                return Ok(jiraConfiguration);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}