using System;

namespace Student_Management
{
	class Student : Person
	{
		private int studentID;
		private Classroom classroom;

		public int StudentID { get => studentID; set => studentID = value; }
		internal Classroom Classroom { get => classroom; set => classroom = value; }

		public Student(string name, int age, 
			int studentID):base(name, age)
		{ 
			this.studentID = studentID;
		}

		public override void showInformation()
		{
			Console.WriteLine($"Student Name : {Name} | Student Age : {Age} " +
								$"| Student ID : {StudentID}");
		}
	}
}
