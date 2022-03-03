using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNullAquariumSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                raceEntry.AddDriver(null);

            });


        }

        [Test]
        public void DriverIsAlreadyAddedSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                var unitDriver = new UnitDriver("dinko", new UnitCar("kon", 22, 222));
                raceEntry.AddDriver(unitDriver);
                raceEntry.AddDriver(unitDriver);

            });


        }

        [Test]
        public void AddDriverSHouldWork()
        {
            var raceEntry = new RaceEntry();
            var unitDriver = new UnitDriver("dinko", new UnitCar("kon", 22, 222));
            var result = raceEntry.AddDriver(unitDriver);

            Assert.AreEqual(result, "Driver dinko added in race.");
        }

        [Test]
        public void CalculateAverageSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                var unitDriver = new UnitDriver("dinko", new UnitCar("kon", 22, 222));
                raceEntry.AddDriver(unitDriver);

                var result = raceEntry.CalculateAverageHorsePower();

                Assert.AreEqual(result, "The race cannot start with less than 2 participants.");

            });


        }

        [Test]
        public void CalculateAverageSHouldWork()
        {

            var raceEntry = new RaceEntry();
            var unitDriver = new UnitDriver("dinko", new UnitCar("kon", 22, 222));
            var unitDriver2 = new UnitDriver("kiro", new UnitCar("kon", 24, 224));
            raceEntry.AddDriver(unitDriver);
            raceEntry.AddDriver(unitDriver2);

            var result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(result, 23);



        }
    }
}