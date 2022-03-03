using NUnit.Framework;
using System;
using BankSafe;


namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;

        private Item item;

        private Item item2;
        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("kiro", "23");
            item2 = new Item("kiro", "233");

        }

        [Test]
        public void AddItemShouldThrowExceptionWhenThereIsNoSuchCell()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A5", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void AddItemShouldThrowExceptionWhenCellIsAlreadyTaken()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A4", item);
                vault.AddItem("A4", item2);
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void AddItemShouldThrowExceptionWhenItemIdIsAlreadyInside()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A4", item);
                vault.AddItem("B4", item);
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }

        [Test]
        public void AddItemShouldWork()
        {
                var result = vault.AddItem("A4", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenThereIsNoSuchCell()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A5", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A4", item);
                vault.RemoveItem("A4", item2);
            });

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

        [Test]
        public void RemoveItemShouldWork()
        {
                vault.AddItem("A4", item);
                var result = vault.RemoveItem("A4", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }
    }
}