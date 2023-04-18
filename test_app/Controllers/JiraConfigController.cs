using System;
using System.Web.Http;
using test_app.Models.Configuration;

namespace test_app.Controllers
{
    public class JiraConfigController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ConfigureJira([FromBody]JiraConfig config)
        {
            try
            {
                // Logic to configure Jira
                return Ok("Jira configuration successful");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to configure Jira: " + ex.Message);
            }
        }
    }
}