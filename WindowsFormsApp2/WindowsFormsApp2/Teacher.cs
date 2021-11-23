using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Teacher:Person
    {
        private List<Student> StudentList = new List<Student>();
        private List<Student> CourseWorkStudents;
        private int MaxNumberOfCourseWorks;
        private string subject;
        public int maxcount { get { return MaxNumberOfCourseWorks; } set { MaxNumberOfCourseWorks = value; } }
        public List<Student> studentlist { get { return StudentList; } set { StudentList = value; } }
        public Teacher(int MaxNumberOfCourseWorks, string subject, string name, string surname, int age, Adress adress) : base(name, surname, age, adress)
        {
            this.subject = subject;
            this.MaxNumberOfCourseWorks = MaxNumberOfCourseWorks;
            CourseWorkStudents = new List<Student>(MaxNumberOfCourseWorks);

        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public int getMaxNumberOfCourseWorks() { return this.MaxNumberOfCourseWorks; }
        public void setMaxNumberOfCourseWorks(int maxNum) { this.MaxNumberOfCourseWorks = maxNum; }
        public List<Student> getCourseWorkStudents() { return this.CourseWorkStudents; }
        public void setCourseWorkStudents(List<Student> students) { this.CourseWorkStudents = students; }
        public void AddCourseWorkStudent(Student student)
        {
            if (CourseWorkStudents.Count == MaxNumberOfCourseWorks) throw new IndexOutOfRangeException("Max num of students!");
            else CourseWorkStudents.Add(student);
        }
        public string GetInfoTeacher()
        {
            return base.GetInfo() + subject.ToString();
        }
        public void RemoveStudent(int i)
        {
            StudentList.RemoveAt(i);
        }
    }
}
