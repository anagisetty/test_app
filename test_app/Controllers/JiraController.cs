using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test_app.Models;

namespace test_app.Controllers
{
    public class JiraController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ConfigureJira(JiraConfiguration configuration)
        {
            //Validate the configuration
            if (configuration == null || string.IsNullOrWhiteSpace(configuration.Url) || string.IsNullOrWhiteSpace(configuration.Username) || string.IsNullOrWhiteSpace(configuration.Password))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Required parameter missing.");
            }

            //Configure Jira
            try
            {
                //Connect to Jira
                JiraConnection con = new JiraConnection(configuration.Url, configuration.Username, configuration.Password);
                con.Connect();

                //Validate the connection
                if (!con.IsConnected)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Unable to connect to Jira.");
                }

                //Validate the credentials
                if (!con.ValidateCredentials())
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid credentials.");
                }

                //If all validations are successful, save the configuration
                configuration.Save();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}