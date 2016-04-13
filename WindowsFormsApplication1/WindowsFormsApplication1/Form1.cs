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
        StudentLibrary student = new StudentLibrary();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            student.Add(textBoxName.Text, textBoxSurname.Text, textBoxBirthdey.Text);
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxBirthdey.Clear();
            textBox1.Clear();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label1.Text = student.HaveSuchFild(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            label1.Text = student.ShowStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;
            label1.Text = student.ShowOne(i);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            student.Remove(str);
            //textBox1.Clear();
        }
    }

    class StudentLibrary
    {
        List<Student> listOfStudents = new List<Student>();

      
        public void Add(string n, string l, string b)
        {
            Student someSudent = new Student(n, l, b);
            listOfStudents.Add(someSudent);
        }
        public string HaveSuchFild(string str)
        {
                for (int i = 0; i < listOfStudents.Count; i++)
                {
                    if (listOfStudents[i].Name == str || listOfStudents[i].LastName == str || listOfStudents[i].Birthday == str)
                    {
                        return listOfStudents[i].Name+" "+listOfStudents[i].LastName + " " + listOfStudents[i].Birthday;
                    }
                }
                return "";
            }
        public string ShowStudents()
        {
            string s = null;
            for (int i = 0; i < listOfStudents.Count; i++)
            {
                s += listOfStudents[i].Name + " " + listOfStudents[i].LastName + " " + listOfStudents[i].Birthday +"\n";
            }
            return s;
        }
        public string ShowOne(int i)
        {
            try
            {
                return listOfStudents[i].Name + " " + listOfStudents[i].LastName + " " + listOfStudents[i].Birthday;
            }
            catch(ArgumentOutOfRangeException)
            {
                return "There is no student with such number)";
            }
            
        }
        public void Remove(string str)
        {
            for(int i=0; i<listOfStudents.Count; i++)
            {
                if (listOfStudents[i].Name == str || listOfStudents[i].LastName == str || listOfStudents[i].Birthday == str)
                {
                    listOfStudents.RemoveAt(i);
                }
            }         
        }
    }
        
    }

    class Student
    {
        public string Name { get; set;}
        public string LastName { get; set; }
        public string Birthday { get; set; }
    
        public Student(string n, string l, string b)
        {
            Name = n;
            LastName = l;
            Birthday = b;
        }
    }

    

 