using NUnit.Framework;
using System.Collections.Generic;
using DriverSearch;

namespace DriverSearch.Tests
{
    [TestFixture]
    public class SearchTests
    {
        private List<Driver> drivers = null!;

        [SetUp]
        public void Setup()
        {
            drivers = new List<Driver>
            {
                new Driver(1, 0, 0),
                new Driver(2, 1, 1),
                new Driver(3, 2, 2),
                new Driver(4, 10, 10),
                new Driver(5, 20, 20),
                new Driver(6, 3, 3)
            };
        }

        [Test]
        public void SortSearch_ReturnsFiveDrivers()
        {
            var search = new SortSearch();
            var result = search.Find(drivers, 0, 0);

            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public void ManualSearch_FindsNearestDriver()
        {
            var search = new ManualSearch();
            var result = search.Find(drivers, 0, 0);

            Assert.That(result[0].Id, Is.EqualTo(1));
        }

        [Test]
        public void QueueSearch_ReturnsFiveDrivers()
        {
            var search = new QueueSearch();
            var result = search.Find(drivers, 0, 0);

            Assert.That(result.Count, Is.EqualTo(5));
        }
    }
}