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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            InitialComboBox();
        }
        public void InitialComboBox()
        {
            this.comboBox1.Items.AddRange(Enum.GetNames(typeof(typeStudent)));
        }
        public void CreateNewStudent()
        {
            string name = this.textBox1.Text;
            string surname = this.textBox2.Text;
            int age = Convert.ToInt32(this.textBox3.Text);
            int groupe = Convert.ToInt32(this.textBox4.Text);
            string city = this.textBox5.Text;
            string street = this.textBox6.Text;
            int house = int.Parse(this.textBox7.Text);
            Adress address = new Adress(city, street, house);
            typeStudent type1 = (typeStudent)this.comboBox1.SelectedIndex;
            Student student = new Student(groupe, name, surname, age, address, type1);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
