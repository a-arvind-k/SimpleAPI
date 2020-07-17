using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{

    public class UnitTest1
    {
        public ValuesController controller= new ValuesController();

        [Fact]
        public void GetReturnCorectNumber()
        {
            var returnVal= controller.Get(1);
            Assert.Equal("Arv",returnVal.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
