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
        public void ReduceArrayTest()
        {

        }
    }
}