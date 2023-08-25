using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    internal class GetQuarterStartTests
    {

        [TestCase("2023-01-01")]
        [TestCase("2023-01-10")]
        [TestCase("2023-02-10")]
        [TestCase("2023-03-10")]
        [TestCase("2023-03-31")]
        [Test]
        public void Quarter_Starts_In_January(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 01, 01), Quarterly.GetQuarterStartFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 01, 01), dt.GetQuarterStart());
        }

        [TestCase("2023-04-01")]
        [TestCase("2023-04-10")]
        [TestCase("2023-05-10")]
        [TestCase("2023-05-10")]
        [TestCase("2023-06-30")]
        [Test]
        public void Quarter_Starts_In_April(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 04, 01), Quarterly.GetQuarterStartFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 04, 01), dt.GetQuarterStart());
        }

        [TestCase("2023-07-01")]
        [TestCase("2023-07-10")]
        [TestCase("2023-08-10")]
        [TestCase("2023-09-10")]
        [TestCase("2023-09-30")]
        [Test]
        public void Quarter_Starts_In_July(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 07, 01), Quarterly.GetQuarterStartFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 07, 01), dt.GetQuarterStart());
        }

        [TestCase("2023-10-01")]
        [TestCase("2023-10-10")]
        [TestCase("2023-11-10")]
        [TestCase("2023-12-10")]
        [TestCase("2023-12-31")]
        [Test]
        public void Quarter_Starts_In_October(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 10, 01), Quarterly.GetQuarterStartFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 10, 01), dt.GetQuarterStart());
        }
    }
}
