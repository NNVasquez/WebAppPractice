using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppPractice.Controllers
{
    public class FizzBuzzController : ApiController
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        public List<string> GetFizzBuzz(int num)
        {
            List<string> result = new List<string>();

            bool mod3;
            bool mod5;

            for (int i = 1; i <= num; i++) {

                 mod3 = i % 3 == 0 ? true : false;
                 mod5 = i % 5 == 0 ? true : false;

                if (mod3 && mod5)
                    result.Add("FizzBuzz");
                else if (mod3)
                    result.Add("Fizz");
                else if (mod5)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());


            }
            return result;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}