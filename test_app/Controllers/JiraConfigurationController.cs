using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_App.Models;

namespace Test_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraConfigurationController : ControllerBase
    {
        // GET api/JiraConfiguration
        [HttpGet]
        public ActionResult<IEnumerable<JiraConfiguration>> Get()
        {
            JiraConfiguration jiraConfiguration = new JiraConfiguration();

            //Get configuration details from database
            jiraConfiguration = GetConfigurationFromDatabase();

            return Ok(jiraConfiguration);
        }

        // POST api/JiraConfiguration
        [HttpPost]
        public ActionResult<JiraConfiguration> Post([FromBody] JiraConfiguration jiraConfiguration)
        {
            if (jiraConfiguration == null)
            {
                return BadRequest();
            }
            else
            {
                //Save configuration details to database
                SaveConfigurationToDatabase(jiraConfiguration);

                return Ok(jiraConfiguration);
            }
        }

        // PUT api/JiraConfiguration
        [HttpPut]
        public ActionResult<JiraConfiguration> Put([FromBody] JiraConfiguration jiraConfiguration)
        {
            if (jiraConfiguration == null)
            {
                return BadRequest();
            }
            else
            {
                //Update configuration details in database
                UpdateConfigurationInDatabase(jiraConfiguration);

                return Ok(jiraConfiguration);
            }
        }

        // DELETE api/JiraConfiguration
        [HttpDelete]
        public ActionResult<JiraConfiguration> Delete([FromBody] JiraConfiguration jiraConfiguration)
        {
            if (jiraConfiguration == null)
            {
                return BadRequest();
            }
            else
            {
                //Delete configuration details from database
                DeleteConfigurationFromDatabase(jiraConfiguration);

                return Ok(jiraConfiguration);
            }
        }

        //Get configuration details from database
        public static JiraConfiguration GetConfigurationFromDatabase()
        {
            //Database code
            return null;
        }

        //Save configuration details to database 
        public static void SaveConfigurationToDatabase(JiraConfiguration jiraConfiguration)
        {
            //Database code
        }

        //Update configuration details in database
        public static void UpdateConfigurationInDatabase(JiraConfiguration jiraConfiguration)
        {
            //Database code
        }

        //Delete configuration details from database
        public static void DeleteConfigurationFromDatabase(JiraConfiguration jiraConfiguration)
        {
            //Database code
        }
    }
}