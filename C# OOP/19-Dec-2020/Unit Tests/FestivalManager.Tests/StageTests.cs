// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {
        //[Test]
        //   public void ValidateNullValueShouldThrowException()
        //   {
        //	Exception ex = Assert.Throws<ArgumentException>(() =>
        //	{
        //		var song1 = new Song("Ветрове", new TimeSpan(0, 3, 30));
        //		var song2 = new Song("Бурни Нощи", new TimeSpan(0, 2, 30));

        //		var performer = new Performer("Ivan", "Ivanov", 19);
        //		Stage stage = new Stage();


        //	});
        //}

        private Song song;
        private Performer performer;
        private Stage stage;

        [SetUp]
        public void SetUp()
        {
            this.performer = new Performer("Sisi", "Smith", 25);
            this.song = new Song("Fly", new TimeSpan(12, 23, 62));
            this.stage = new Stage();
        }

        [Test]
        public void ConstructorShouldWorkCorect()
        {
            Assert.IsNotNull(this.performer);
        }

        [Test]
        public void IReadOnlyPerformers()
        {
            Assert.IsNotNull(this.stage.Performers);
        }

        [TestCase(null)]
        public void AddPerformerShouldThrowArgumentNullException(Performer performer)
        {
            Assert.Throws<ArgumentNullException>(() => this.stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerShouldThrowArgumenExceptionIfPerformerAgeAreLessThan18()
        {
            Performer performer = new Performer("DI", "ZI", 16);
            Assert.Throws<ArgumentException>(() => this.stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerShouldAddCorect()
        {
            Performer performer = new Performer("DI", "ZI", 26);
            this.stage.AddPerformer(performer);
            this.stage.AddPerformer(this.performer);

            int expectedCount = 2;
            Assert.AreEqual(expectedCount, this.stage.Performers.Count);
        }

        [TestCase(null)]
        public void AddSongShouldThrowArgumentNullException(Song song)
        {
            Assert.Throws<ArgumentNullException>(() => this.stage.AddSong(song));
        }

        [Test]
        public void AddSongShouldThrowArgumenExceptionIfDurationIsLessThanOneMinute()
        {
            Song song = new Song("FLy", new TimeSpan(0, 0, 30));
            Assert.Throws<ArgumentException>(() => this.stage.AddSong(song));
        }

        [Test]
        public void AddSongShouldAddCorect()
        {
            Song song = new Song("FLy", new TimeSpan(0, 1, 30));
            this.stage.AddSong(song);
            /* Assert.AreEqual(1, ); *///?????
        }

        [TestCase(null, "Jesi")]
        [TestCase("Fly", null)]
        public void AddSongToPerformerShouldThrowArgumentNullException(string songName, string performerName)
        {
            Assert.Throws<ArgumentNullException>(() => this.stage.AddSongToPerformer(songName, performerName));
        }

        [Test]
        public void AddSongToPerformerShouldAddCorect()
        {
            this.stage.AddPerformer(this.performer);
            this.stage.AddSong(this.song);


            string expected = $"{song} will be performed by {performer}";
            Assert.AreEqual(expected, stage.AddSongToPerformer(song.Name, performer.FullName));

            Assert.AreEqual(1, this.performer.SongList.Count);
        }

        [Test]
        public void Play()
        {
            this.stage.AddPerformer(this.performer);
            this.performer.SongList.Add(this.song);

            var songsCount = this.stage.Performers.Sum(p => p.SongList.Count());

            string expected = $"{this.stage.Performers.Count} performers played {songsCount} songs";

            Assert.AreEqual(expected, this.stage.Play());
        }
    }
}
//        [Test]
//        public void ConstructorShouldWorkCorect()
//        {
//            Assert.IsNotNull(this.performer);
//        }

//        [Test]
//        public void IReadOnlyPerformers()
//        {
//            Assert.IsNotNull(this.stage.Performers);
//        }

//        [Test]
//        public void AddSongToPerformerShouldAddCorect()
//        {
//            this.stage.AddPerformer(this.performer);
//            this.stage.AddSong(this.song);
//            string expected = $"{song} will be performed by {performer}";
//            Assert.AreEqual(expected, stage.AddSongToPerformer(song.Name, performer.FullName));
//            Assert.AreEqual(1, this.performer.SongList.Count);
//        }

//        [Test]
//        public void AddSongToPerformerShouldWork()
//        {
//            var performer = new Performer("Ivan", "Ivanov", 19);
//            Song song = new Song("kirovata pesen", new TimeSpan(0, 2, 30));
//            Stage stage = new Stage();
//            stage.AddPerformer(performer);
//            stage.AddSong(song);
//            var result = stage.AddSongToPerformer(song.Name, performer.FullName);
//            Assert.AreEqual(result, $"{song.Name} will be performed by {performer.FullName}");
//            Assert.AreEqual(1, performer.SongList.Count);
//        }

//        [Test]
//        public void Play()
//        {
//            this.stage.AddPerformer(this.performer);
//            this.performer.SongList.Add(this.song);

//            var songsCount = this.stage.Performers.Sum(p => p.SongList.Count());

//            string expected = $"{this.stage.Performers.Count} performers played {songsCount} songs";

//            Assert.AreEqual(expected, this.stage.Play());
//        }

//        [TestCase(null)]
//        public void AddPerformerShouldThrowArgumentNullException(Performer performer)
//        {
//            Assert.Throws<ArgumentNullException>(() => this.stage.AddPerformer(performer));
//        }

//        [TestCase(null)]
//        public void AddSongShouldThrowArgumentNullException(Song song)
//        {
//            Assert.Throws<ArgumentNullException>(() => this.stage.AddSong(song));
//        }

//        [Test]
//        public void AddPerformerShouldThrowArgumenExceptionIfPerformerAgeAreLessThan18()
//        {
//            Performer performer = new Performer("DI", "ZI", 16);
//            Assert.Throws<ArgumentException>(() => this.stage.AddPerformer(performer));
//        }

//        [Test]
//        public void AddPerformerShouldAddCorect()
//        {
//            Performer performer = new Performer("DI", "ZI", 26);
//            this.stage.AddPerformer(performer);
//            this.stage.AddPerformer(this.performer);

//            int expectedCount = 2;
//            Assert.AreEqual(expectedCount, this.stage.Performers.Count);
//        }

//        [Test]
//        public void AddSongShouldThrowArgumenExceptionIfDurationIsLessThanOneMinute()
//        {
//            Song song = new Song("FLy", new TimeSpan(0, 0, 30));
//            Assert.Throws<ArgumentException>(() => this.stage.AddSong(song));
//        }

//        [Test]
//        public void AddSongShouldAddCorect()
//        {
//            Song song = new Song("FLy", new TimeSpan(0, 1, 30));
//            this.stage.AddSong(song);
//            /* Assert.AreEqual(1, ); *///?????
//        }

//        [Test]
//        public void PerformerAgeShouldThrowException()
//        {
//            Exception ex = Assert.Throws<ArgumentException>(() =>
//            {
//                var performer = new Performer("Ivan", "Ivanov", 17);

//                Stage stage = new Stage();

//                stage.AddPerformer(performer);

//            });

//            Assert.AreEqual(ex.Message, "You can only add performers that are at least 18.");

//        }

//        [Test]
//        public void AddPerformerShouldWork()
//        {

//            var performer = new Performer("Ivan", "Ivanov", 19);

//            Stage stage = new Stage();

//            stage.AddPerformer(performer);

//            List<Performer> performers = new List<Performer>();

//            performers.Add(performer);


//            Assert.AreEqual(performer.FullName, performers[0].FullName);

//        }

//        [Test]

//        public void PerformerSongShouldThrowException()
//        {
//            Exception ex = Assert.Throws<ArgumentException>(() =>
//            {
//                var performer = new Performer("Ivan", "Ivanov", 19);

//                Stage stage = new Stage();

//                stage.AddPerformer(performer);

//                Song song = new Song("kirovata pesen", new TimeSpan(0, 0, 30));

//                stage.AddSong(song);

//            });

//            Assert.AreEqual(ex.Message, "You can only add songs that are longer than 1 minute.");

//        }

//        [Test]
//        public void AddSongShouldWork()
//        {

//            var performer = new Performer("Ivan", "Ivanov", 19);

//            Stage stage = new Stage();

//            stage.AddPerformer(performer);

//            Song song = new Song("kirovata pesen", new TimeSpan(0, 2, 30));

//            List<Song> songs = new List<Song>();

//            stage.AddSong(song);

//            songs.Add(song);


//            Assert.AreEqual(song.Name, songs[0].Name);

//        }



//        [Test]
//        public void PlayShouldWork()
//        {

//            var performer = new Performer("Ivan", "Ivanov", 19);

//            var performers = new List<Performer>();

//            Song song = new Song("kirovata pesen", new TimeSpan(0, 2, 30));

//            Stage stage = new Stage();

//            stage.AddPerformer(performer);
//            stage.AddSong(song);

//            performer.SongList.Add(song);

//            performers.Add(performer);


//            var songsCount = performers.Sum(p => p.SongList.Count());



//            var result = stage.Play();


//            Assert.AreEqual(result, $"{performers.Count} performers played {songsCount} songs");

//        }


//        [Test]
//        public void GetPerformerShouldThrowException()
//        {
//            Exception ex = Assert.Throws<ArgumentException>(() =>
//            {
//                var performer = new Performer("Ivan", "Ivanov", 17);

//                var song = new Song("Ivan", new TimeSpan(0, 2, 30));

//                Stage stage = new Stage();

//                var result = stage.AddSongToPerformer(song.Name, "Dinko");

//            });

//            Assert.AreEqual(ex.Message, "There is no performer with this name.");

//        }

//        [Test]
//        public void GetSongShouldThrowException()
//        {
//            Exception ex = Assert.Throws<ArgumentException>(() =>
//            {
//                var song = new Song("Ivan", new TimeSpan(0, 2, 30));
//                var performer = new Performer("Ivan", "Ivanov", 19);


//                Stage stage = new Stage();

//                stage.AddPerformer(performer);

//                var result = stage.AddSongToPerformer("Sondi", performer.FullName);

//            });

//            Assert.AreEqual(ex.Message, "There is no song with this name.");

//        }

//        //[Test]
//        //public void GetPerformerShouldWork()
//        //{

//        //    var song = new Song("Ivan", new TimeSpan(0, 2, 30));
//        //    var performer = new Performer("Ivan", "Ivanov", 19);



//        //    Stage stage = new Stage();

//        //    stage.AddPerformer(performer);
//        //    stage.AddSong(song);

//        //    stage.AddSongToPerformer(song.Name, performer.FullName);

//        //    Assert.AreEqual(ex.Message, "There is no performer with this name.");


//        //}

//        [Test]
//        public void PerformerShouldThrowExp()
//        {
//            Stage stage = new Stage();
//            Performer performer = null;

//            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
//        }

//        [Test]
//        public void AddNullSongShouldThrowExp()
//        {
//            Stage stage = new Stage();
//            Song song = null;

//            Assert.Throws<ArgumentNullException>(() => stage.AddSong(song));
//        }

//        [Test]
//        public void PerformerShouldThrowExp2()
//        {
//            Stage stage = new Stage();
//            Performer performer = null;

//            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
//        }

//        [Test]
//        public void PerformerInvalidAgeShouldThrowExp()
//        {
//            Stage stage = new Stage();
//            Performer performer = new Performer("Gosho", "Ivan", 15);

//            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
//        }

//        [Test]
//        public void PerformerShouldBeAddedSuccessfully()
//        {
//            Stage stage = new Stage();
//            Performer performer = new Performer("Gosho", "Ivan", 19);

//            stage.AddPerformer(performer);

//            int expectedResult = 1;
//            int actualResult = stage.Performers.Count;

//            Assert.AreEqual(expectedResult, actualResult);
//        }

//        [Test]
//        public void AddNullSongShouldThrowExp2()
//        {
//            Stage stage = new Stage();
//            Song song = null;

//            Assert.Throws<ArgumentNullException>(() => stage.AddSong(song));
//        }

//        [Test]
//        public void AddSongDurationShouldBeMoreThanOneExp()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("Gosho", new TimeSpan(0, 0, 50));

//            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
//        }

//        [Test]
//        public void AddSongShouldWorkPropietly()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("Gosho", new TimeSpan(0, 2, 00));

//            stage.AddSong(song);

//            var expectedResult = "Gosho";
//            var actualResult = song.Name;

//            var expectedDuration = TimeSpan.FromMinutes(2);
//            var actualDuration = song.Duration;

//            Assert.AreEqual(expectedResult, actualResult);

//            Assert.AreEqual(expectedDuration, actualDuration);
//        }

//        [Test]
//        public void AddSongToPerformerShouldWorkPropietly()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("SenTrope", new TimeSpan(0, 3, 31));
//            Performer performer = new Performer("Vasil", "Boqnov", 43);

//            stage.AddPerformer(performer);
//            stage.AddSong(song);

//            performer.SongList.Add(song);

//            int expectedResult = 1;
//            int actualResult = performer.SongList.Count;

//            Assert.AreEqual(expectedResult, actualResult);
//        }

//        [Test]
//        public void GetPerformerShouldThrowExp()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("SenTrope", new TimeSpan(0, 3, 31));
//            Performer performer = new Performer("Vasil", "Boqnov", 43);

//            stage.AddPerformer(performer);
//            stage.AddSong(song);

//            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("SenTrope", "Ivan"));

//        }

//        [Test]
//        public void GetSongShouldThrowExp()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("SenTrope", new TimeSpan(0, 3, 31));
//            Performer performer = new Performer("Vasil", "Boqnov", 43);

//            stage.AddPerformer(performer);
//            stage.AddSong(song);

//            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Bazooka", $"{performer.FullName}"));
//        }

//        [Test]
//        public void PlayShouldWorkPropietly()
//        {
//            Stage stage = new Stage();
//            Song song = new Song("SenTrope", new TimeSpan(0, 3, 31));
//            Performer performer = new Performer("Vasil", "Boqnov", 43);

//            stage.AddPerformer(performer);
//            stage.AddSong(song);

//            performer.SongList.Add(song);

//            stage.Play();

//            int expectedResult = 1;
//            int actualResult = performer.SongList.Count;

//            Assert.AreEqual(expectedResult, actualResult);
//        }
//    }
//}

