using System;

namespace dbpr
{
	class dbpr
	{
		static void Main(string[] args)
		{
			var rnd = new Random();
			while (true)
			{
				Console.Write("nyx ");
				if (rnd.NextDouble() < 0.01) {
					Console.Write("I TOLD YOU TO STAY IN THE TREES ");
				}
			}
		}
	}
}