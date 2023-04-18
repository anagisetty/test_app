using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_App.Models;

namespace Test_App.Controllers
{
    public class JiraController : ApiController
    {
        // GET: api/Jira
        [HttpGet]
        public HttpResponseMessage GetJiraConfiguration()
        {
            try
            {
                JiraConfiguration jiraConfig = new JiraConfiguration();
                jiraConfig.ServerUrl = "https://jira.example.com";
                jiraConfig.Username = "username";
                jiraConfig.Password = "password";
                jiraConfig.ClientId = "clientId";
                jiraConfig.ClientSecret = "clientSecret";

                return Request.CreateResponse(HttpStatusCode.OK, jiraConfig);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // POST: api/Jira
        [HttpPost]
        public HttpResponseMessage PostJiraConfiguration([FromBody]JiraConfiguration jiraConfig)
        {
            try
            {
                // do something with jiraConfig
                return Request.CreateResponse(HttpStatusCode.OK, "Jira configuration successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}