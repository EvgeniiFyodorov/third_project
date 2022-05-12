using NUnit.Framework;

namespace jenkinsTestTarget
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var x = "test";
            Assert.IsTrue(x.Contains("test"));
        }
    }
}