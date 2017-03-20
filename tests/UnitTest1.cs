using Xunit;
using lib;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var num = Class1.Add(1,2);

            Assert.True(num == 3,$"Sum is expected to be 3.");
        }
    }
}
