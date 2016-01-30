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
    public class HelloController : ApiController
    {
        public string[] Post([FromBody] int[] value)
        {
            List<string> hellos = new List<string>();
            for (int i = 0; i < value[0]; i++)
                hellos.Add("Hello World");
            return hellos.ToArray();
        }


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
