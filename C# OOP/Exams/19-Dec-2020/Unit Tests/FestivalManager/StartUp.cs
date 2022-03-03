namespace FestivalManager
{	
	using Entities;
	using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StartUp
	{
		public static void Main(string[] args)
		{
			//example usage of the Stage class
			//var song1 = new Song("Ветрове", new TimeSpan(0,3,30));
			//var song2 = new Song("Бурни Нощи", new TimeSpan(0, 2, 30));

			//var performer = new Performer("Ivan", "Ivanov", 19);
			//Stage stage = new Stage();

			//stage.AddSong(song1);
			//stage.AddSong(song2);
			//stage.AddPerformer(performer);

			//         Console.WriteLine(stage.AddSongToPerformer("Ветрове", "Ivan Ivanov"));

			//         Console.WriteLine(stage.Play());

			//var performer = new Performer("Ivan", "Ivanov", 19);



			//Song song = new Song("kirovata pesen", new TimeSpan(0, 2, 30));

			//Stage stage = new Stage();

			//stage.AddPerformer(performer);
			//stage.AddSong(song);

			//performer.SongList.Add(song);


			//var result = stage.AddSongToPerformer(song.Name, performer.FullName);

			//var resultMethod = stage.AddSongToPerformer(song.Name, performer.FullName);

			//         Console.WriteLine(result);
			//         Console.WriteLine(resultMethod);
			//         Console.WriteLine($"{song.Name} will be performed by {performer.FullName}");

			//var performer = new Performer("Ivan", "Ivanov", 19);

			//var performers = new List<Performer>();

			//Song song = new Song("kirovata pesen", new TimeSpan(0, 2, 30));

			//Stage stage = new Stage();

			//stage.AddPerformer(performer);
			//stage.AddSong(song);

			//performer.SongList.Add(song);

			//performers.Add(performer);

			//var songsCount = performers.Sum(p => p.SongList.Count());

			//var result = stage.Play();

			//         Console.WriteLine(result);

			//         Console.WriteLine($"{performers.Count} performers played {songsCount} songs");

			var song = new Song("Ivan", new TimeSpan(0, 2, 30));
			var performer = new Performer("Ivan", "Ivanov", 19);


			Stage stage = new Stage();

			stage.AddPerformer(performer);

			var result = stage.AddSongToPerformer("Sondi", "Ivan Ivanov");

            Console.WriteLine(result);
		}
	}
}