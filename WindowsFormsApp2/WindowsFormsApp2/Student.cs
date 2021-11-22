using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    enum typeStudent { exelent, good, three, bad, verybad };
    class Student:Person
    {
        private int group;
        private typeStudent type;
        public Student(int group, string name, string surname, int age, Adress adress, typeStudent type) : base(name, surname, age, adress)
        {
            this.group = group;
            this.type = type;

        }
        public typeStudent TypeStudent
        {
            get { return type; }
            set { type = value; }
        }
        public int Group { get { return group; } set { group = value; } }

        public string getAllInformation()
        {
            return base.GetInfo() + group.ToString();
        }
    }
}
