using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Lion lion = new Lion("0", "Zoo");
            Wolf wolf = new Wolf("Section for animals", "Zoo");

            lion.MakeNoize();
            wolf.MakeNoize();
        }

        [Theory]
        [InlineData("section A", "Zoo")]
        [InlineData("sample1", "Forest")]
        [InlineData("sample2", "Sample")]
        public void TestFunctionCalculationVal(string a, string b)
        {
            Lion lion = new Lion(a, b);
            Wolf wolf = new Wolf(a, b);

            Assert.Equal(wolf.Location, lion.Location);
            Assert.Equal(wolf.Boundaries, lion.Boundaries);
        }
    }
}
