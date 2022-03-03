namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using Presents;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void AddNullAquariumSHouldTHrowException()
        {

            Assert.Throws<ArgumentNullException>(() =>
            {
                var bag = new Bag();
                bag.Create(null);


            });


        }

        [Test]
        public void CreatePresentThatALreadyExistsSHouldThrowException()
        {

            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var bag = new Bag();
                var present = new Present("dinko", 23);

                bag.Create(present);
                bag.Create(present);
            });

            Assert.AreEqual(ex.Message, "This present already exists!");


        }

        [Test]
        public void AddPresentShouldWork()
        {

            var bag = new Bag();

            var present = new Present("dinko", 23);

            var result = bag.Create(present);

            Assert.AreEqual(result, $"Successfully added present {present.Name}.");



        }

        [Test]
        public void RemoveSHouldWOrk()
        {

            var bag = new Bag();
            var present = new Present("Dinko", 23);

            bag.Create(present);
            var result = bag.Remove(present);
            var result2 = bag.Remove(new Present("kir", 2));

            Assert.AreEqual(result, true);
            Assert.AreEqual(result2, false);
        }

        [Test]
        public void LeastShouldWork()
        {

            var bag = new Bag();
            var present = new Present("Dinko", 23);
            var present2 = new Present("Kiro", 7);

            bag.Create(present);
            bag.Create(present2);

            var result = bag.GetPresentWithLeastMagic();


            Assert.AreEqual(result, present2);
        }

        [Test]
        public void GetShouldWork()
        {

            var bag = new Bag();
            var present = new Present("Dinko", 23);
            var present2 = new Present("Kiro", 7);

            bag.Create(present);
            bag.Create(present2);

            var result = bag.GetPresent("Dinko");


            Assert.AreEqual(result, present);
        }

        [Test]
        public void Get2ShouldWork()
        {

            var bag = new Bag();
            var present = new Present("Dinko", 23);
            var present2 = new Present("Kiro", 7);

            bag.Create(present);
            bag.Create(present2);

            var result = bag.GetPresents();


            Assert.AreEqual(result.Count, 2);
        }

    }
}
