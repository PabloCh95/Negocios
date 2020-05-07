using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controller
{
    public class PyCController : ApiController
    {
        // GET: api/PyC
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PyC/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PyC
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PyC/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PyC/5
        public void Delete(int id)
        {
        }
    }
}
