using System;

namespace Student_Management
{
	class Teacher : Person
	{
		private int teacherId;
		private int experienceYear;
		private float rating = 0;

		public int ExperienceYear { get => experienceYear; set => experienceYear = value; }
		public int TeacherId { get => teacherId; set => teacherId = value; }

		public Teacher(int teacherId, int experienceYear,
						string name, int age) : base(name, age)
		{
			this.teacherId = teacherId;
			this.experienceYear = experienceYear;
		}

		public Teacher()
		{

		}

		public override void showInformation()
		{
			Console.WriteLine($"Teacher : {Name} | Age : {Age} |" +
								$" Teacher ID : {teacherId} | Experience Year : {experienceYear}");
		}
	}
}
