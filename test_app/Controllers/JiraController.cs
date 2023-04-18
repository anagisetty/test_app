namespace test_app
{
    using System.Web.Http;

    public class JiraController : ApiController
    {
        // GET: api/Jira
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Jira/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jira
        public void Post([FromBody]string value)
        {
            // Configuration of Jira
        }

        // PUT: api/Jira/5
        public void Put(int id, [FromBody]string value)
        {
            // Configuration of Jira
        }

        // DELETE: api/Jira/5
        public void Delete(int id)
        {
            // Configuration of Jira
        }
    }
}