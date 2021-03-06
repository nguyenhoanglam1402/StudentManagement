using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management
{
	class Major
	{
		private string nameMajor;
		private int numberOfLession;
		private Teacher teacher;

		public string NameMajor { get => nameMajor; set => nameMajor = value; }
		public int NumberOfLession { get => numberOfLession; set => numberOfLession = value; }


	}
}
