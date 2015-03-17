using System;

namespace csharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Variables
			string name = "Jeff";
			int favorite_number = 5;
//			favorites = ["Apollo 13", "purple", "cookies"]
			string[] favorites = new string[3];
			favorites[0] = "Apollo 13";
			favorites[1] = "purple";
			favorites[2] = "cookies";

			// Loops
			for (int i = 0; i < favorites.Length; i += 1)
			{
				Console.WriteLine(favorites[i]);
			}
			foreach (string favorite in favorites)
			{
				Console.WriteLine(favorite);
			}
			Landmarks l = new Landmarks();
			l.DisplayAll();
			Divvy d = new Divvy ();
			d.ShowStations();

			// Functions - landmarks
			// Web access - divvy

//			Console.WriteLine("Hello");


		}
	}
}
