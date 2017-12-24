using System;
using Xunit;
using logic;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
			var expectedMessage = "Hello Sam!";
			var actualMessage = HelloWorld.GetMessage("Sam");
			Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
