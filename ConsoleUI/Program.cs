using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			string name;

			do
			{
				Console.Write("What is your name: ");
				name = Console.ReadLine();
				if ( name.ToLower() == "tim" )
				{
					Console.WriteLine("Hello Professor");
				}
				else if ( name.ToLower() != "exit" )
				{
					Console.WriteLine($"Hi {name}");
				}
			} while ( name.ToLower() != "exit" );
		}
	}
}
