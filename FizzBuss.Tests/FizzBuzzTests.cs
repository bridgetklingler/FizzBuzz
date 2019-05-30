using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get_Returns_2_For_2()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(2);
            Assert.Equal("2", result);
        }
        [Fact]
        public void Get_Returns_for_3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(6);
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void Get_Returns_For_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(5);
            Assert.Equal("Buzz", result);
        }


    }

}
