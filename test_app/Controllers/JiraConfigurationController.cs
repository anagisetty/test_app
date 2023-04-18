using System.Web.Http;

namespace test_app
{
    public class JiraConfigurationController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetJiraConfiguration()
        {
            try
            {
                //Get Jira Configuration
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult UpdateJiraConfiguration(JiraConfiguration jiraConfiguration)
        {
            try
            {
                //Update Jira Configuration
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }

    public class JiraConfiguration
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}