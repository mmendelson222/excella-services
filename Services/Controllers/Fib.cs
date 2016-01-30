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
    public class FibController : ApiController
    {
        public int[] Post([FromBody] int[] value)
        {
            List<int> fibs = new List<int>();
            for (int i = 0; i < value.Length; i++)
                fibs.Add(Generate(value[i]));
            return fibs.ToArray();
        }

        List<int> sequence = new List<int>();
        private int Generate(int p)
        {
            if (sequence.Count < p)
            {
                CreateFibSequence(p);
            }

            return sequence[p - 1];
        }

        /// <summary>
        /// create sequence of at least the given length
        /// </summary>
        private void CreateFibSequence(int p)
        {
            sequence = new List<int>() {1, 1};

            for (int i=2; i<p; i++)
                sequence.Add(sequence[i-1] + sequence[i-2]);
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
