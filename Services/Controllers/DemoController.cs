using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Rules;

namespace Services.Controllers
{
    public class DemoController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Demo/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public DemoOutputModel Factors([FromBody]DemoInputModel value)
        {
            DemoOutputModel output = new DemoOutputModel();
            if (value != null)
            {
                int [] ints = SomeExtensions.Primes(value.Count);
                string sfactors = string.Join(",", ints.Select(x => x.ToString()).ToArray());
                output.Message = string.Format("Factors of {0}: {1}", value.InputString, sfactors);
                output.Count = value.Count;
            }
            return output;
        }

        // PUT: api/Demo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
