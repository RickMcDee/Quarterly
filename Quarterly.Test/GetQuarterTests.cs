using NUnit.Framework;

namespace Quarterly.Test
{

    [TestFixture]
    public class GetQuarterTests
    {

        [TestCase("2023-01-01")]
        [TestCase("2023-02-01")]
        [TestCase("2023-03-01")]
        [Test]
        public void Quarter_Is_One(DateTime dt)
        {
            Assert.AreEqual(1, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreEqual(1, dt.GetQuarter());
        }

        [TestCase("2023-04-01")]
        [TestCase("2023-05-01")]
        [TestCase("2023-06-01")]
        [Test]
        public void Quarter_Is_Two(DateTime dt)
        {
            Assert.AreEqual(2, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreEqual(2, dt.GetQuarter());
        }

        [TestCase("2023-07-01")]
        [TestCase("2023-08-01")]
        [TestCase("2023-09-01")]
        [Test]
        public void Quarter_Is_Three(DateTime dt)
        {
            Assert.AreEqual(3, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreEqual(3, dt.GetQuarter());
        }

        [TestCase("2023-10-01")]
        [TestCase("2023-11-01")]
        [TestCase("2023-12-01")]
        [Test]
        public void Quarter_Is_Four(DateTime dt)
        {
            Assert.AreEqual(4, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreEqual(4, dt.GetQuarter());
        }

        [TestCase("2023-05-01")]
        [TestCase("2023-08-01")]
        [TestCase("2023-11-01")]
        [Test]
        public void Quarter_Is_Not_One(DateTime dt)
        {
            Assert.AreNotEqual(1, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreNotEqual(1, dt.GetQuarter());
        }

        [TestCase("2023-02-01")]
        [TestCase("2023-08-01")]
        [TestCase("2023-11-01")]
        [Test]
        public void Quarter_Is_Not_Two(DateTime dt)
        {
            Assert.AreNotEqual(2, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreNotEqual(2, dt.GetQuarter());
        }

        [TestCase("2023-02-01")]
        [TestCase("2023-05-01")]
        [TestCase("2023-11-01")]
        [Test]
        public void Quarter_Is_Not_Three(DateTime dt)
        {
            Assert.AreNotEqual(3, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreNotEqual(3, dt.GetQuarter());
        }

        [TestCase("2023-02-01")]
        [TestCase("2023-05-01")]
        [TestCase("2023-08-01")]
        [Test]
        public void Quarter_Is_Not_Four(DateTime dt)
        {
            Assert.AreNotEqual(4, Quarterly.GetQuarterFromDateTime(dt));
            Assert.AreNotEqual(4, dt.GetQuarter());
        }
    }
}