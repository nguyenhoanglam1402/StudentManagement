using System;
using System.Linq;

namespace Student_Management
{
	class App
	{
		private static School school = new School();
		public void launchApp()
		{
			int choice = 0;
			string schoolName = "";
			Console.Write("Set your School name : -> ");
			schoolName = Console.ReadLine();
			do
			{
				Console.Clear(); // Clear all sreen to start new working session.
				Console.Beep(); // Speak beep to start the new working session.
				GC.Collect();  // To collect the garbage or unused memory.

				Menu.showMenu(schoolName);
				Console.WriteLine("Enter your choice : -> ");
				choice = int.Parse(Console.ReadLine());
				Console.Clear(); // Clear all screen after choose the selection.
				switch (choice)
				{
					case 1:
						addNewStudent();
						break;
					case 2:
						addTeacher();
						break;
					case 3:
						addClass();
						break;
					case 4:
						findStudent();
						break;
					case 5:
						showStudent();
						break;
					case 6:
						showTeacher();
						break;
				}
			} while (choice < 7);
		}

		private static void addNewStudent()
		{
			Console.Write("How many student do you want to add : -> ");
			int amount = int.Parse(Console.ReadLine());
			for (int index = 0; index < amount; index++)
			{
				Console.Write("\n\nPlease enter the student name: -> ");
				string name = Console.ReadLine();
				Console.Write("Pleaser enter the student age: -> ");
				int age = int.Parse(Console.ReadLine());
				Console.Write("Please enter the student ID: -> ");
				int id = int.Parse(Console.ReadLine());
				Student student = new Student(name, age, id);
				school.addStudent(student);
			}
			Console.WriteLine("Done ! Press any key to return the Menu board. ");
			Console.ReadKey();
		}

		private static void addTeacher()
		{
			Console.Write("How many Teacher do you want to add : -> ");
			int amount = int.Parse(Console.ReadLine());
			for (int index = 0; index < amount; index++)
			{
				Console.Write("\n\nPlease enter the teacher name : -> ");
				string name = Console.ReadLine();
				Console.Write("Please enter the teacher age : -> ");
				int age = int.Parse(Console.ReadLine());
				Console.Write("Please enter the teacher id : -> ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Please enter the teacher experience year : -> ");
				int experienceYear = int.Parse(Console.ReadLine());
				Teacher teacher = new Teacher(id, experienceYear, name, age);
				school.addTeacher(teacher);
			}
			Console.WriteLine("Done ! Press any key to return the Menu board. ");
			Console.ReadKey();
		}

		private static void addClass()
		{
			Console.Write("Set Class Name : ->\n(Class name is unique and do not duplicated) ");
			string nameClass = Console.ReadLine();
			Console.Write("Set the Main Teacher () : -> ");
			int id = int.Parse(Console.ReadLine());
			var resultTeacher = from teacher in school.Teachers
								where teacher.TeacherId == id
								select teacher;
			Classroom classroom = new Classroom(nameClass, resultTeacher.FirstOrDefault());
			school.addClass(classroom);
		}

		private static void findStudent()
		{
			Console.Write("Please enter the Student ID : -> ");
			int id = int.Parse(Console.ReadLine());
			Student student = school.findStudent(id);
			student.showInformation();
			Console.ReadKey();
		}

		private static void showStudent()
		{
			Console.WriteLine("List of students");
			foreach (Student student in school.Students)
			{
				student.showInformation();
			}
			Console.ReadKey();
		}

		private static void showTeacher()
		{
			Console.WriteLine("List of teachers");
			foreach (Teacher teacher in school.Teachers)
			{
				teacher.showInformation();
			}
			Console.ReadKey();
		}

	}
}
