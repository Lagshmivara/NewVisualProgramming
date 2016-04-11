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

            string str = textBox1.Text;
            Student stdnt1 = new Student("Lena", "Shynkarenko", "19.03.98");
            Student stdnt2 = new Student("Yaroslav", "Nosov", "05.07.92");
            Student stdnt3 = new Student("Marina", "Ilinskaya", "20.11.89");
            Student stdnt4 = new Student("Mariya", "Ulitina", "13.02.95");
            Student stdnt5 = new Student("Anatoliy", "Kulakov", "25.12.94");
            Student stdnt6 = new Student("Roman", "Sidorov", "15.06.99");
            Student stdnt7 = new Student("Denis", "Shynkarenko", "02.09.84");

            label1.Text = stdnt1.Method(stdnt1, str);

        }

        private void label1_Click(object sender, EventArgs e)
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

        public string Method(Student ob, string str)
        {
            if(ob.Name.Contains(str)|| ob.Surname.Contains(str)|| ob.Birthday.Contains(str))
            {
                return ob.Name + "\n" + ob.Surname + "\n" + ob.Birthday;
            }
            else
            {
                return "Not found";
            }
        }
    }

    /*class StudentsArray
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

    }*/
}
 