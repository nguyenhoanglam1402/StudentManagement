using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management
{
	class Person
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public Person()
		{

		}

		public virtual void showInformation()
		{
			Console.WriteLine($"\tName : {Name}, Age : {Age}");
		}
	}
}
