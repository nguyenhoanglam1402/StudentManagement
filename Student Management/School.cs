using System.Collections.Generic;
using System.Linq;

namespace Student_Management
{
	class School
	{
		private string nameSchool;
		private List<Teacher> teachers = new List<Teacher>();
		private List<Classroom> classrooms = new List<Classroom>();
		private List<Student> students = new List<Student>();

		public string NameSchool { get => nameSchool; set => nameSchool = value; }
		internal List<Teacher> Teachers { get => teachers; set => teachers = value; }
		internal List<Classroom> Classrooms { get => classrooms; set => classrooms = value; }
		internal List<Student> Students { get => students; set => students = value; }

		public void addTeacher(Teacher teacher)
		{
			teachers.Add(teacher);
		}

		public void addClass(Classroom classroom)
		{
			classrooms.Add(classroom);
		}

		public Teacher findTeacher(int teacherID)
		{
			var resultTeacher = from teacher in teachers
								where teacher.TeacherId == teacherID
								select teacher;
			return resultTeacher.FirstOrDefault();
		}

		public Student findStudent(int studentID)
		{
			var resultStudent = from student in students
								where student.StudentID == studentID
								select student;
			return resultStudent.FirstOrDefault();
		}

		public void addStudent(Student student)
		{
			Students.Add(student);
		}

		public void showStudent()
		{
			foreach(Student student in Students)
			{
				student.showInformation();
			}
		}

		public void showTeacher()
		{
			foreach(Teacher teacher in Teachers)
			{
				teacher.showInformation();
			}
		}
	}
}
