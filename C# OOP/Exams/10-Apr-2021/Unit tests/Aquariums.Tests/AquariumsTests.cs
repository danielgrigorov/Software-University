namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;


    public class AquariumsTests
    {

        [Test]
        public void AddNullAquariumSHouldTHrowException()
        {

            Assert.Throws<ArgumentNullException>(() =>
            {
                var aquarium = new Aquarium(null, 2);
            });


        }

        [Test]
        public void AddNullAquariumSHouldTHrowExceptionAgain()
        {

            Exception ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var aquarium = new Aquarium(null, 1);


            });

            Assert.AreEqual(ex.Message, "Invalid aquarium name! (Parameter 'value')");


        }

        [Test]
        public void AddNullCapacityAquariumSHouldTHrowException()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var aquarium = new Aquarium("Dinko", -1);
            });


        }

        [Test]
        public void AddNullAquariumCapacitySHouldTHrowExceptionAgain()
        {

            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                var aquarium = new Aquarium("Dinko", -1);


            });

            Assert.AreEqual(ex.Message, "Invalid aquarium capacity!");


        }

        [Test]
        public void AddFishToFullAquariumSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                var fish = new Fish("Kolu");
                var fish2 = new Fish("Kolu2");

                aquarium.Add(fish);
                aquarium.Add(fish2);
            });


        }

        [Test]
        public void AddFishToFullAquariumSHouldTHrowExceptionAgain()
        {

            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                var fish = new Fish("Kolu");
                var fish2 = new Fish("Kolu2");

                aquarium.Add(fish);
                aquarium.Add(fish2);

            });

            Assert.AreEqual(ex.Message, "Aquarium is full!");


        }


        [Test]
        public void AddFishShouldWork()
        {



            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Kolu");

            aquarium.Add(fish);

            Assert.AreEqual(1, aquarium.Count);



        }

        [Test]
        public void RemoveFishSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                aquarium.RemoveFish("Sonic");
            });


        }

        [Test]
        public void RemoveFishSHouldTHrowExceptionAgain()
        {

            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                aquarium.RemoveFish("Kolu");

            });

            Assert.AreEqual(ex.Message, "Fish with the name Kolu doesn't exist!");


        }

        [Test]
        public void RemoveFishSHouldWork()
        {

            var aquarium = new Aquarium("Dinko", 1);

            aquarium.Add(new Fish("Sonic"));

            aquarium.RemoveFish("Sonic");

            Assert.AreEqual(0, aquarium.Count);



        }

        [Test]
        public void SellFishSHouldTHrowException()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                aquarium.SellFish("Sonic");
            });


        }

        [Test]
        public void SellFishSHouldTHrowExceptionAgain()
        {

            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var aquarium = new Aquarium("Dinko", 1);

                aquarium.SellFish("Kolu");

            });

            Assert.AreEqual(ex.Message, "Fish with the name Kolu doesn't exist!");


        }

        [Test]
        public void SellFishSHouldWork()
        {

            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Sonic");

            aquarium.Add(fish);

            var result = aquarium.SellFish("Sonic");

            Assert.AreEqual(false, fish.Available);
            Assert.AreEqual(result.Name, "Sonic");


        }

        [Test]
        public void SellFishSHouldWorkAgain2()
        {

            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Sonic");

            aquarium.Add(fish);

            var result = aquarium.SellFish("Sonic");

            Assert.AreEqual(result.Name, "Sonic");


        }

        [Test]
        public void ReportSHouldWork()
        {

            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Sonic");

            aquarium.Add(fish);

            var result = aquarium.Report();

            Assert.AreEqual(result, "Fish available at Dinko: Sonic");




        }

        [Test]
        public void ConstructorWorkCorrect()
        {
            Aquarium aquarium = new Aquarium("Dinko", 1);
            Assert.IsNotNull(aquarium);
        }

        [Test]
        public void CounterSHouldWork()
        {



            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Kolu");

            aquarium.Add(fish);

            Assert.AreEqual(1, aquarium.Count);



        }
    }
}
