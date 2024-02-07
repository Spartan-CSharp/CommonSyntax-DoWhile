using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
