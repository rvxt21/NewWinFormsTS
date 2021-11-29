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
    public partial class DeleteTeacher : Form
    {
        public delegate void Send();

        public static event Send SendDeleteTeacher;
        public DeleteTeacher()
        {
            InitializeComponent();
            InitialComboBox();
        }
        public void InitialComboBox()
        {
            //comboBox1.Items.Clear();
            for (int i = 0; i < TeacherList.listTeacher.Count; i++)
            {
                comboBox1.Items.Add(TeacherList.listTeacher[i].Surname + " " + TeacherList.listTeacher[i].Name);
            }

        }
        public void DeletedTeacher()
        {
            string number = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < TeacherList.listTeacher.Count(); i++)
            {
                if (number == TeacherList.listTeacher[i].Surname + " " + TeacherList.listTeacher[i].Name)
                {
                    TeacherList.listTeacher.RemoveAt(i);
                    SendDeleteTeacher?.Invoke();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeletedTeacher();
        }
    }
}
