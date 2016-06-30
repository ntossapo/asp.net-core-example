using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using asp_net_core_example.Controllers;

namespace asp_net_core_example.Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void itShouldBeTrue()
        {
            Assert.Equal(true, true);           
        }

        [Fact]
        public void itShouldBeTrueWhenInput1AndIsFibonacciReturnTrue()
        {
            int value = 1;
            bool expect = true;
            bool result = myController.isFibonacci(value);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void itShouldBeTrueWhenInput2AndIsFibonacciReturnTrue()
        {
            int value = 2;
            bool expect = true;
            bool result = myController.isFibonacci(value);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void itShouldBeTrueWhenInput3AndIsFibonacciReturnTrue()
        {
            int value = 3;
            bool expect = true;
            bool result = myController.isFibonacci(value);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void itShouldBeTrueWhenInput4AndIsFibonacciReturnFalse()
        {
            int value = 4;
            bool expect = false;
            bool result = myController.isFibonacci(value);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void itShouldBeTrueWhenInput5AndIsFibonacciReturnTrue()
        {
            int value = 5;
            bool expect = true;
            bool result = myController.isFibonacci(value);
            Assert.Equal(expect, result);
        }
    }
}
