// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    //using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {
        [Test]
        public void CalculateAverageSHouldTHrowException1()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var stage = new Stage();
                var performer = new Performer("Dinko", "Dinkov", 16);
                stage.AddPerformer(performer);
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException2()
        {

            var stage = new Stage();
            var performer = new Performer("Dinko", "Dinkov", 19);
            stage.AddPerformer(performer);

            var result = stage.Performers.First();

            Assert.AreEqual(result.Age, 19);
            Assert.AreEqual(1, stage.Performers.Count);





        }

        [Test]
        public void CalculateAverageSHouldTHrowException3()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var stage = new Stage();
                var song = new Song("Dinko e hubav", new TimeSpan(0, 0, 23));
                stage.AddSong(song);
            });


        }

        [Test]
        public void CalculateAverageSHouldTHrowException4()
        {

            var stage = new Stage();
            var performer = new Performer("Dinko", "Dinkov", 23);
            var song = new Song("Dinko e hubav", new TimeSpan(0, 2, 23));
            stage.AddSong(song);
            stage.AddPerformer(performer);

            stage.AddSongToPerformer(song.Name, performer.FullName);

            var result = performer.SongList.First();
            var result2 = performer.SongList.Count();

            Assert.AreEqual(result.Name, "Dinko e hubav");
            Assert.AreEqual(result2, 1);


        }


        [Test]
        public void CalculateAverageSHouldTHrowException5()
        {

            var stage = new Stage();
            var performer = new Performer("Dinko", "Dinkov", 23);
            var song = new Song("Dinko e hubav", new TimeSpan(0, 2, 23));
            stage.AddSong(song);
            stage.AddPerformer(performer);

            var result = stage.AddSongToPerformer(song.Name, performer.FullName);


            Assert.AreEqual(result, $"{song} will be performed by {performer.FullName}");


        }

        [Test]
        public void CalculateAverageSHouldTHrowException6()
        {

            var stage = new Stage();
            var performer = new Performer("Dinko", "Dinkov", 23);
            var song = new Song("Dinko e hubav", new TimeSpan(0, 2, 23));
            stage.AddSong(song);
            stage.AddPerformer(performer);

            var result = stage.Play();


            Assert.AreEqual(result, $"{stage.Performers.Count} performers played {performer.SongList.Count} songs");


        }

    }
}