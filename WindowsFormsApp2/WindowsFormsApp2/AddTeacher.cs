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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void AddNewTeacher()
        {
            string name = this.textBox1.Text;
            string surname = this.textBox2.Text;
            int age = Convert.ToInt32(this.textBox3.Text);
            string city = this.textBox6.Text;
            string subject = this.textBox4.Text;
            int maxnum = Convert.ToInt32(this.textBox5.Text);
            string street = this.textBox7.Text;
            int house = Convert.ToInt32(this.textBox8.Text);
            Adress address = new Adress(city, street, house);
            Teacher teacher = new Teacher(maxnum, subject, name, surname, age, address);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
