namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var aquarium = new Aquarium(null, 23);
            });

            Assert.AreEqual(ex.Message, "Invalid aquarium name! (Parameter 'value')");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist2()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                var aquarium = new Aquarium("Dinko", -23);
            });

            Assert.AreEqual(ex.Message, "Invalid aquarium capacity!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist3()
        {
            var aquarium = new Aquarium("Dinko", 23);
            var fish1 = new Fish("Petko");
            var fish2 = new Fish("Kiro");
            aquarium.Add(fish1);
            aquarium.Add(fish2);
            var result = aquarium.Count;

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist4()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);
                var fish1 = new Fish("Petko");
                var fish2 = new Fish("Kiro");
                aquarium.Add(fish1);
                aquarium.Add(fish2);
            });

            Assert.AreEqual(ex.Message, "Aquarium is full!");
        }

        //[Test]
        //public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist5()
        //{
        //    var aquarium = new Aquarium("Dinko", 23);
        //    var fish1 = new Fish("Petko");
        //    aquarium.Add(fish1);
        //    var result = aquarium.

        //    Assert.AreEqual(aquarium.First, 2);
        //}

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist6()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);
                var fish1 = new Fish("Petko");
                aquarium.Add(fish1);
                aquarium.RemoveFish("Kiko");
            });

            Assert.AreEqual(ex.Message, "Fish with the name Kiko doesn't exist!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist7()
        {
                var aquarium = new Aquarium("Dinko", 1);
                var fish1 = new Fish("Petko");
                aquarium.Add(fish1);
                aquarium.RemoveFish("Petko");

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist8()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);
                var fish1 = new Fish("Petko");
                aquarium.Add(fish1);
                aquarium.SellFish("Kiko");
            });

            Assert.AreEqual(ex.Message, "Fish with the name Kiko doesn't exist!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist9()
        {
                var aquarium = new Aquarium("Dinko", 1);
                var fish1 = new Fish("Petko");
                aquarium.Add(fish1);
                var result = aquarium.SellFish("Petko");

            Assert.AreEqual(fish1.Available, false);
            Assert.AreEqual(result, fish1);
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist10()
        {
            var aquarium = new Aquarium("Dinko", 1);
            var fish1 = new Fish("Petko");
            aquarium.Add(fish1);
            var result = aquarium.Report();

            Assert.AreEqual(result, "Fish available at Dinko: Petko");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist11()
        {
            var aquarium = new Aquarium("Dinko", 1);

            var result = aquarium.Name;

            Assert.AreEqual(result, "Dinko");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist12()
        {
            var aquarium = new Aquarium("Dinko", 1);

            var result = aquarium.Capacity;

            Assert.AreEqual(result, 1);
        }
    }
}
