using System;
using static System.Console;

namespace dbpr
{
	class dbpr
	{
		static void Main(string[] args)
		{
			var rnd = new Random();
			while (true)
			{
				Write("nyx ");
				if (rnd.NextDouble() < 0.01)
				{
					Write("I TOLD YOU TO STAY IN THE TREES ");
				}				
			}
		}
	}
}