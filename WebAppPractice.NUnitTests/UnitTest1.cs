using NUnit.Framework;
using System.Collections.Generic;
using WebAppPractice.Controllers;
using System.Numerics;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [Test]
        public void FizzBuzzTestReg()
        {

            FizzBuzzController fizzBuzz = new FizzBuzzController();

            List<string> answer = new List <string>();

            answer.Add("1");
            answer.Add("2");
            answer.Add("Fizz");


            Assert.AreEqual(answer, fizzBuzz.GetFizzBuzz(3));
            //Assert.Pass();
        }
    }

    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciTest()
        {
            FibController fib = new FibController();

            List<string> answer = new List<string>();

            answer.Add("0");
            answer.Add("1");
            answer.Add("1");
            answer.Add("2");
            answer.Add("3");
            answer.Add("5");
            answer.Add("8");
            answer.Add("13");
            answer.Add("21");
            answer.Add("34");

            Assert.AreEqual(answer, fib.Get(10));

        }
    }

    [TestFixture]
    public class SumArrayTests
    {
        [Test]
        public void SumArrayTest()
        {
            SumArrayController sum = new SumArrayController();

            long[] testInput = new long[2] { long.MaxValue, long.MaxValue };

            BigInteger answer = (BigInteger) long.MaxValue + long.MaxValue;

            Assert.AreEqual(answer.ToString(), sum.GetLongs(testInput));
        }
    }

    [TestFixture]
    public class ReduceArrayTests
    {
        [Test]
        public void ReduceArrayEvenLengthTest()
        {
            ReduceController red = new ReduceController();

            int[][] answer = new int[4][]
            {
                new int[] {2,1,1,3},
                new int[] {1,2,3,1},
                new int[] {1,3,2,1},
                new int[] {3,1,1,2}
            };


            Assert.AreEqual("4", red.GetReduced(answer));

        }

        [Test]
        public void ReduceArrayOddTest()
        {
            ReduceController red2 = new ReduceController();

            int[][] answer = new int[5][]
            {
                new int[] {2,1,1,1,3},
                new int[] {1,2,1,3,1},
                new int[] {1,1,2,1,1},
                new int[] {1,3,1,2,1},
                new int[] {3,1,1,1,2}
            };
            //10 vs  14


            Assert.AreEqual("4", red2.GetReduced(answer));
        }
    }

    [TestFixture]
    public class InsertTests
    {
        [Test]
        public void InsertTestBeginning()
        {
            InsertController insert = new InsertController();

            string alphabet = "abcdefghijklmmnopqrstuvwxyz";

            Assert.AreEqual(alphabet, insert.Get('a', "bcdefghijklmmnopqrstuvwxyz"));
        }

        [Test]
        public void InsertTestEnd()
        {
            InsertController insert = new InsertController();

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Assert.AreEqual(alphabet, insert.Get('z', "abcdefghijklmnopqrstuvwxy"));
        }

        [Test]
        public void InsertTestMiddle()
        {
            InsertController insert = new InsertController();

            string alphabet = "abcdefghijklmmnopqrstuvwxyz";

            Assert.AreEqual(alphabet, insert.Get('j', "abcdefghiklmmnopqrstuvwxyz"));
        }

        [Test]
        public void InsertTestJumbledCase()
        {
            InsertController insert = new InsertController();

            string alphabetCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Assert.AreEqual(alphabetCaps, insert.Get('M', "ABCDEFGHIJKLNOPQRSTUVWXYZ"));
        }
    }
}