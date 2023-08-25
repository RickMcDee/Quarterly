using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    internal class GetQuarterEndTests
    {

        [TestCase("2023-01-01")]
        [TestCase("2023-01-10")]
        [TestCase("2023-02-10")]
        [TestCase("2023-03-10")]
        [TestCase("2023-03-31")]
        [Test]
        public void Quarter_Ends_In_March(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 03, 31), Quarterly.GetQuarterEndFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 03, 31), dt.GetQuarterEnd());
        }

        [TestCase("2023-04-01")]
        [TestCase("2023-04-10")]
        [TestCase("2023-05-10")]
        [TestCase("2023-05-10")]
        [TestCase("2023-06-30")]
        [Test]
        public void Quarter_Starts_In_June(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 06, 30), Quarterly.GetQuarterEndFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 06, 30), dt.GetQuarterEnd());
        }

        [TestCase("2023-07-01")]
        [TestCase("2023-07-10")]
        [TestCase("2023-08-10")]
        [TestCase("2023-09-10")]
        [TestCase("2023-09-30")]
        [Test]
        public void Quarter_Starts_In_September(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 09, 30), Quarterly.GetQuarterEndFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 09, 30), dt.GetQuarterEnd());
        }

        [TestCase("2023-10-01")]
        [TestCase("2023-10-10")]
        [TestCase("2023-11-10")]
        [TestCase("2023-12-10")]
        [TestCase("2023-12-31")]
        [Test]
        public void Quarter_Starts_In_December(DateTime dt)
        {
            Assert.AreEqual(new DateTime(2023, 12, 31), Quarterly.GetQuarterEndFromDateTime(dt));
            Assert.AreEqual(new DateTime(2023, 12, 31), dt.GetQuarterEnd());
        }
    }
}
