using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Numerics;
using System.Web.Http;

namespace WebAppPractice.Controllers
{
    public class SumArrayController : ApiController
    {
   
        // GET api/<controller>/5
        public string GetLongs([FromUri] long[] longNums)
        {
            BigInteger result = 0;

            foreach (long n in longNums)
            {
                result += n;
            }


            return result.ToString();
        }

    }
}