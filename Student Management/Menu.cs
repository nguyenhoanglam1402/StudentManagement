using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management
{
	class Menu
	{
		public static void showMenu(string schoolName)
		{
			Console.WriteLine("\t\t __________________________________________");
			Console.WriteLine("\t\t|                                          |");
			Console.WriteLine($"\t\t     [ {schoolName} HIGH SCHOOL SYSTEMS ]	");
			Console.WriteLine("\t\t|__________________________________________|");
			Console.WriteLine("\t\t|	[1] Add more student					");
			Console.WriteLine("\t\t|	[2] Add Teacher							");
			Console.WriteLine("\t\t|	[3] Add Class							");
			Console.WriteLine("\t\t|	[4] Find Student						");
			Console.WriteLine("\t\t|	[5] Show Students						");
			Console.WriteLine("\t\t|	[6] Show Teachers						");
			Console.WriteLine("\t\t|	[Any key] Exit							");
			Console.WriteLine("\t\t|__________________________________________|");
			Console.WriteLine("\t\t|______________[.|*.<~>.|*.]_______________|\n\n");
		}
	}
}
