using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    internal class GetTotalDaysInQuarterTests
    {

        [TestCase("2023-01-01")]
        [Test]
        public void Quarters_With_90_Days(DateTime dt)
        {
            Assert.AreEqual(90, Quarterly.GetTotalDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(90, dt.GetTotalDaysInQuarter());
        }

        [TestCase("2023-04-01")]
        [TestCase("2024-01-01")] // February has 29 days here
        [Test]
        public void Quarters_With_91_Days(DateTime dt)
        {
            Assert.AreEqual(91, Quarterly.GetTotalDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(91, dt.GetTotalDaysInQuarter());
        }

        [TestCase("2023-07-01")]
        [TestCase("2023-10-01")]
        [Test]
        public void Quarters_With_92_Days(DateTime dt)
        {
            Assert.AreEqual(92, Quarterly.GetTotalDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(92, dt.GetTotalDaysInQuarter());
        }
    }
}
