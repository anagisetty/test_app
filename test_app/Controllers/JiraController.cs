using System.Web.Http;
using Test_App;

namespace Test_App
{
    public class JiraController : ApiController
    {
        [HttpPost]
        [Route("jira/config")]
        public IHttpActionResult SetJiraConfig(JiraConfig config)
        {
            //Validate model
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            //Save config
            var result = JiraConfigManager.Save(config);
            if(result)
            {
                return Ok();
            }

            return InternalServerError();
        }
    }
    
    public class JiraConfig
    {
        public string BaseUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public static class JiraConfigManager
    {
        public static bool Save(JiraConfig config)
        {
            //Save config to db
            return true;
        }
    }
}