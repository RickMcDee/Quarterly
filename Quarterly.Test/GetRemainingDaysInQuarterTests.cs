using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    internal class GetRemainingDaysInQuarterTests
    {

        [TestCase("2023-01-01")]
        [Test]
        public void Full_Quarter(DateTime dt)
        {
            Assert.AreEqual(90, Quarterly.GetRemainingDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(90, dt.GetRemainingDaysInQuarter());
        }

        [TestCase("2023-03-31")]
        [Test]
        public void One_Day_Left(DateTime dt)
        {
            Assert.AreEqual(1, Quarterly.GetRemainingDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(1, dt.GetRemainingDaysInQuarter());
        }

        [TestCase("2023-02-28")]
        [Test]
        public void No_Leap_Year(DateTime dt)
        {
            Assert.AreEqual(32, Quarterly.GetRemainingDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(32, dt.GetRemainingDaysInQuarter());
        }

        [TestCase("2024-02-28")]
        [Test]
        public void Leap_Year(DateTime dt)
        {
            Assert.AreEqual(33, Quarterly.GetRemainingDaysInQuarterFromDateTime(dt));
            Assert.AreEqual(33, dt.GetRemainingDaysInQuarter());
        }
    }
}
