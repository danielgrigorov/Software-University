using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist()
    {
        Exception ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var hero = new Hero(null, 0);
            var herorep = new HeroRepository();
            herorep.Create(null);
        });

        Assert.AreEqual(ex.Message, "Hero is null (Parameter 'hero')");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist2()
    {
        Exception ex = Assert.Throws<InvalidOperationException>(() =>
        {
            var hero = new Hero("Dinko", 2);
            var herorep = new HeroRepository();
            herorep.Create(hero);
            herorep.Create(hero);
        });

        Assert.AreEqual(ex.Message, "Hero with name Dinko already exists");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist3()
    {
            var hero = new Hero("Dinko", 2);
            var herorep = new HeroRepository();
            var result = herorep.Create(hero);

        Assert.AreEqual(result, "Successfully added hero Dinko with level 2");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist4()
    {
        Exception ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var hero = new Hero("Dinko",23);
            var herorep = new HeroRepository();
            herorep.Create(hero);
            herorep.Remove(null);
        });

        Assert.AreEqual(ex.Message, "Name cannot be null (Parameter 'name')");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist5()
    {
            var hero = new Hero("Dinko", 23);
            var herorep = new HeroRepository();
            herorep.Create(hero);
            var result = herorep.Remove("Dinko");

        Assert.AreEqual(result, true);
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist6()
    {
        var hero = new Hero("Dinko", 23);
        var hero2 = new Hero("Kiro", 2);
        var herorep = new HeroRepository();
        herorep.Create(hero);
        herorep.Create(hero2);
        var result = herorep.GetHeroWithHighestLevel();

        Assert.AreEqual(result.Name, "Dinko");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist7()
    {
        var hero = new Hero("Dinko", 23);
        var hero2 = new Hero("Kiro", 2);
        var herorep = new HeroRepository();
        herorep.Create(hero);
        herorep.Create(hero2);
        var result = herorep.GetHero("Dinko");

        Assert.AreEqual(result.Name, "Dinko");
    }

    [Test]
    public void RemoveItemShouldThrowExceptionWhenSuchItemDoesNotExist8()
    {
        var hero = new Hero("Dinko", 23);
        var hero2 = new Hero("Kiro", 2);
        var herorep = new HeroRepository();
        herorep.Create(hero);
        herorep.Create(hero2);
        var result = herorep.GetHero("Dinko");

        Assert.AreEqual(herorep.Heroes.Count, 2);
    }

}