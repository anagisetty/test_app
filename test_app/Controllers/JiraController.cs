using System.Web.Http;
using test_app;

namespace test_app
{
    public class JiraController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ConfigureJira(string jiraUrl, string username, string password)
        {
            // Validate parameters
            if (string.IsNullOrWhiteSpace(jiraUrl) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Invalid parameters");
            }

            // Perform configuration
            JiraConfig configuration = new JiraConfig(jiraUrl, username, password);
            configuration.Configure();

            return Ok();
        }
    }
}