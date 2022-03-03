namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var bag = new Bag();
                bag.Create(null);
            });

            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'Present is null')");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist2()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var bag = new Bag();
                Present present = new Present("Dinko", 23);
                bag.Create(present);
                bag.Create(present);
            });

            Assert.AreEqual(ex.Message, "This present already exists!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist3()
        {
                var bag = new Bag();
                Present present = new Present("Dinko", 23);
                var result = bag.Create(present);

            Assert.AreEqual(1, bag.GetPresents().Count);
            Assert.AreEqual(result, "Successfully added present Dinko.");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist4()
        {
            var bag = new Bag();
            Present present = new Present("Dinko", 23);
            bag.Create(present);
            var result = bag.Remove(present);

            Assert.AreEqual(0, bag.GetPresents().Count);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist5()
        {
            var bag = new Bag();
            Present present = new Present("Dinko", 23);
            Present present2 = new Present("Dinko2", 25);
            bag.Create(present);
            bag.Create(present2);
            var result = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(result, present);
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist6()
        {
            var bag = new Bag();
            Present present = new Present("Dinko", 23);
            Present present2 = new Present("Dinko2", 25);
            bag.Create(present);
            bag.Create(present2);
            var result = bag.GetPresent(present.Name);

            Assert.AreEqual(result, present);
        }
    }
}
