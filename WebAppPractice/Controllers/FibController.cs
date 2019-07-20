using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppPractice.Controllers
{
    public class FibController : ApiController
    {

        public List<string> Get(int num)
        {
            return FibHelper(num);
        }

        public List<string> FibHelper(int n)
        {
            List<string> results = new List<string>();

            FibRecurs(ref results, n, 1,0,1);

            return results;
        }

        public void FibRecurs(ref List<string> lst, int length, int counter, int a, int b)
        {
            if (counter <= length)
            {
                //Console.Write("{0} ", a);
                lst.Add(a.ToString());
                FibRecurs(ref lst, length, counter+1, b, a + b);
            }      
        }

    }
}