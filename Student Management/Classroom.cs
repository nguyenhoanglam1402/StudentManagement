using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management
{
	class Classroom 
	{
		private string className;
		private Teacher mainTeacher;

		public string ClassName { get => className; set => className = value; }
		internal Teacher MainTeacher { get => mainTeacher; set => mainTeacher = value; }

		public Classroom(string className, Teacher mainTeacher)
		{
			this.className = className;
			this.mainTeacher = mainTeacher;
		}

		public void showInformation()
		{
			Console.WriteLine($"Class name : {className} | Main Teacher : {mainTeacher}");
		}
	}
}
