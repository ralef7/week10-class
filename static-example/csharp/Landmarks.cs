using System;


namespace csharp
{
	class Landmarks
	{
		public void Display(string venue, string cost, string location)
		{
			Console.WriteLine("{0} costs ${1} and is located at {2}", venue, cost, location);
		}

		public void Display(string venue, int cost, string location)
		{
			Console.WriteLine("{0} costs ${1} and is located at {2}", venue, cost, location);
		}


		public void DisplayAll()
		{
			Display("Wrigley Field", 40, "1033 W. Addison St.");
			Display("The Bean", "0", "Millenium Park.");
			Display("The John Hancock Tower", "35", "875 N. Michigan Ave.");
			Display("The United Center", "75", "1901 W. Madison St.");
			Display("The Shakespeare Theater", "40", "Navy Pier");

		}
	}
}


