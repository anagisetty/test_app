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
        public JiraController()
        {
        }

        [HttpGet]
        [Route("configure")]
        public ActionResult ConfigureJira()
        {
            //Code for configuration of JIRA
            return new OkObjectResult("JIRA configured successfully");
        }
    }
}