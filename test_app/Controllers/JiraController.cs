using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_app.Models;

namespace test_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        [HttpGet]
        [Route("configureJira")]
        public IActionResult ConfigureJira(int jiraId)
        {
            var jiraConfig = new JiraConfig
            {
                JiraId = jiraId,
                Url = "https://jira.example.com/",
                UserName = "jirauser",
                Password = "jirapassword",
                IsActive = true
            };

            try
            {
                // Logic to store the Jira configuration
                return Ok($"Jira configuration saved successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error while saving Jira configuration. {ex.Message}");
            }
        }
    }
}