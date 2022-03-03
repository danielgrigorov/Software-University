namespace FestivalManager
{	
	using Entities;
	using System;
    using System.Linq;

    public static class StartUp
	{
		public static void Main(string[] args)
		{
			//example usage of the Stage class
			var stage = new Stage();
			var performer = new Performer("Dinko", "Dinkov", 23);
			var song = new Song("Dinko e hubav", new TimeSpan(0, 2, 23));
			stage.AddSong(song);

			stage.AddSongToPerformer(song.Name, performer.FullName);

			var result = performer.SongList.First();
			var result2 = performer.SongList.Count();

            Console.WriteLine(result);

		}
	}
}