using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppPractice.Controllers
{
    public class ReduceController : ApiController
    {
        // GET api/<controller>/5
        public string GetReduced([FromUri] int[][] nums)
        {

            int leftDiagonal = 0;
            int rightDiagonal = 0;

            string result;

            for(int j = 0; j< nums.GetLength(0); j++)
            {
                leftDiagonal += nums[j][j];
                rightDiagonal += (nums[j][nums.GetLength(0) - (1 + j)]);
            }


            result = Math.Abs(leftDiagonal - rightDiagonal).ToString();



            return result;
        }
    }
}