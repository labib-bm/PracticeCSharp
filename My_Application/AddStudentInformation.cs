using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Application
{
    public partial class Add_Student : Form
    {
        //initially these fields are blank
        string studentFirstName = "";
        string studentSureName = "";
        string studentEmail = "";
        string studentID = "";
        string studentContactNumber = "";
        string studentDateOfBirth = "";

        
        //to return student information, getter used here.
        public string getStudentFirstName()
        {
            return studentFirstName;
        }public string getStudentSureName()
        {
            return studentSureName;
        }public string getStudentEmail()
        {
            return studentEmail;
        }public string getStudentID()
        {
            return studentID;
        }public string getStudentContact()
        {
            return studentContactNumber;
        }public string getStudentDOB()
        {
            return studentDateOfBirth;
        }

        public Add_Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Action for Button
        private void button1_Click(object sender, EventArgs e)
        {
            //If any information is missing or not provided or provided blank or null value and clicked on save button, it will show message and  ask to complete all fields.
            if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == "") || (textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == "") || (textBox5.Text.Trim() == "") || (textBox6.Text.Trim() == ""))
            {
                MessageBox.Show("Please provide all informations");
            }
            else
            {
                //inputs will be stored to this class variable for showing or updating purpose
                this.studentFirstName = textBox1.Text;
                this.studentSureName = textBox2.Text;
                this.studentEmail = textBox3.Text;
                this.studentID = textBox4.Text;
                this.studentContactNumber = textBox5.Text;
                this.studentDateOfBirth = textBox6.Text;
                //after clicking "Save" button this message will be visible and all the fields will be reset as Empty or Null value.
                MessageBox.Show("Saved Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
        //to close the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
