using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    class Student
    {
        public Student(string n, string s, string b)
        {
            Name = n;
            Surname = s;
            Birthday = b;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Birthday { get; private set; }
    }

    class StudentsArray
    {
        object[] a;

        public StudentsArray(int size)
        {
            a = new object[size];
            Length = size;
        }   
        public int Length { get; set; }
       
        public object this[int index]
        {
            get
            {
                return a[index];
            }
            set
            {
                a[index] = value;
            }
        }

    }

    class CreateStudent
    {
        public void Main()
        {
            StudentsArray stdnt = new StudentsArray(7);
            stdnt[1] = new Student("Lena", "Shynkarenko", "19.03.98");
            stdnt[2] = new Student("Yaroslav", "Nosov", "05.07.92");
            stdnt[3] = new Student("Marina", "Ilinskaya", "20.11.89");
            stdnt[4] = new Student("Mariya", "Ulitina", "13.02.95");
            stdnt[5] = new Student("Anatoliy", "Kulakov", "25.12.94");
            stdnt[6] = new Student("Roman", "Sidorov", "15.06.99");
            stdnt[7] = new Student("Denis", "Shynkarenko", "02.09.84");
        }
    }
}
 