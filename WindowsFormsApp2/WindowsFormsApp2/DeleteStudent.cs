using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DeleteStudent : Form
    {
        public delegate void Send();
        public static event Send SendDeletedS;
        public DeleteStudent()
        {
            InitializeComponent();
        }
        public void InitialComboBox()
        {
            for (int i = 0; i < TeacherList.listTeacher.Count(); i++)
            {
                List<Student> students = TeacherList.listTeacher[i].studentlist;
                for (int j = 0; j < students.Count(); j++)
                {
                    comboBox1.Items.Add(students[j].Surname + " " + students[j].Name);
                }
            }
        }
        public void DeletedStudent()
        {
            string number = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < TeacherList.listTeacher.Count(); i++)
            {
                List<Student> students = TeacherList.listTeacher[i].studentlist;
                for (int j = 0; j < students.Count(); j++)
                {
                    if (number == students[j].Surname + " " + students[j].Name)
                    {
                        TeacherList.listTeacher[i].RemoveStudent(j);
                        SendDeletedS?.Invoke();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeletedStudent();

        }
    }
}
