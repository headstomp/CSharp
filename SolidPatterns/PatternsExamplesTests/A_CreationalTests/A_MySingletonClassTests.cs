using NUnit.Framework;
using PatternsExamples.A_Creational.A_Singleton;

namespace PatternsExamplesTests.A_CreationalTests
{
    [TestFixture]
    public class MySingletonClassTests
    {
        [Test]
        public void ShouldReturnSameInstanceWithMultipleCalls()
        {
            MySingletonClass first = MySingletonClass.Instance;
            MySingletonClass second = MySingletonClass.Instance;
            Assert.AreSame(first, second);
            first.SomeValue++;
            Assert.AreEqual(first.SomeValue, second.SomeValue);
            second.SomeValue++;
            Assert.AreEqual(first.SomeValue, second.SomeValue);
            first.Dispose();
            second.Dispose();
        }
    }
}