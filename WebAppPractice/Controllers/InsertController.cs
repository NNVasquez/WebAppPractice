using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppPractice.Controllers
{
    public class InsertController : ApiController
    {
        // GET api/<controller>/5
        public string Get(char c, string alphabet)
        {
            int charVal = (int) Char.ToLower(c);

            int place = charVal - 97; //ascii value of beginning of lowercase english alphabet

            alphabet = alphabet.Insert(place, c.ToString());



            return alphabet.ToString();
        }

    }
}