using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CalculateAverageSHouldTHrowException()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var bankBault = new BankVault();
                Item item = new Item("Dinko", "23");
                var result = bankBault.AddItem("F343", item);

                Assert.AreEqual(result, "Cell doesn't exists!");
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException2()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var bankBault = new BankVault();
                Item item = new Item("Dinko", "23");
                bankBault.AddItem("A3", item);
                var result = bankBault.AddItem("A3", item);

                Assert.AreEqual(result, "Cell is already taken!");
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException3()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                var bankBault = new BankVault();
                Item item = new Item("Dinko", "23");
                bankBault.AddItem("A3", item);
                var result = bankBault.AddItem("A4", item);

                Assert.AreEqual(result, "Item is already in cell!");
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException4()
        {

                var bankBault = new BankVault();
                Item item = new Item("Dinko", "23");
                var result = bankBault.AddItem("A4", item);

                Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");


        }

        [Test]
        public void CalculateAverageSHouldTHrowException5()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var bankBault = new BankVault();
                var item = new Item("Dinko", "23");
                var result = bankBault.RemoveItem("F343", item);

                Assert.AreEqual(result, "Cell doesn't exists!");
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException6()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var bankBault = new BankVault();
                Item item = new Item("Dinko", "23");
                bankBault.AddItem("A3", item);
                var result = bankBault.RemoveItem("A3", new Item("Kiro", "233"));

                Assert.AreEqual(result, "Item in that cell doesn't exists!");
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException7()
        {

            var bankBault = new BankVault();
            Item item = new Item("Dinko", "23");
            var result = bankBault.AddItem("A4", item);
            var result2 = bankBault.RemoveItem("A4", item);

            Assert.AreEqual(result2, $"Remove item:{item.ItemId} successfully!");


        }
    }
}