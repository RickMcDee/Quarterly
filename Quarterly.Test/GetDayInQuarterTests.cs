using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    internal class GetDayInQuarterTests
    {

        [TestCase("2023-01-01")]
        [TestCase("2023-04-01")]
        [TestCase("2023-07-01")]
        [TestCase("2023-10-01")]
        [Test]
        public void First_Day(DateTime dt)
        {
            Assert.AreEqual(1, Quarterly.GetDayInQuarterFromDateTime(dt));
            Assert.AreEqual(1, dt.GetDayInQuarter());
        }

        [TestCase("2023-01-23")]
        [TestCase("2023-04-23")]
        [TestCase("2023-07-23")]
        [TestCase("2023-10-23")]
        [Test]
        public void TwentyThird_Day(DateTime dt)
        {
            Assert.AreEqual(23, Quarterly.GetDayInQuarterFromDateTime(dt));
            Assert.AreEqual(23, dt.GetDayInQuarter());
        }
    }
}
