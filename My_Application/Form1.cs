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
    public partial class Form1 : Form
    {
        //To store student information
        string studentFirstName = "";
        string studentSureName = "";
        string studentEmail = "";
        string studentID = "";
        string studentContactNumber = "";
        string studentDateOfBirth = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Headline
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "University of Roehampton";
            //label1.Text = "Student Enrollment";
        }
        //Add student information Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Creating object of Add_Student Class for adding student information
            Add_Student addInfo = new Add_Student();
            addInfo.ShowDialog(); //To go to that form
            //These methods are used to get added informations
            studentFirstName = addInfo.getStudentFirstName();
            studentSureName = addInfo.getStudentSureName();
            studentEmail = addInfo.getStudentEmail();
            studentID = addInfo.getStudentID();
            studentContactNumber = addInfo.getStudentContact();
            studentDateOfBirth = addInfo.getStudentDOB();
        }
        //Show Student Information Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Creating object to access the class form
            ShowStudentInformation showInfo = new ShowStudentInformation();
            //if any information is missing then form will not open until this class has all informations
            if (studentFirstName == "")
            {
                MessageBox.Show("Please provide Student Information first");
            }
            //If all information is provided, informations will pass to show information class to display informations
            else
            {
                showInfo.setInfo(studentFirstName, studentSureName, studentEmail, studentID, studentContactNumber, studentDateOfBirth);
                showInfo.ShowDialog();
            }
        }
        //Design Pattern 1: Creational Design Pattern (Show Course List by selecting Department and Years)
        private void button3_Click(object sender, EventArgs e)
        {
            //Ask user if the user want to enter to this form
            DialogResult dr = MessageBox.Show("This section will show course list for perspective department.\nDo you want to proceed??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if user want to access this form, must have to click yes
            if (dr == DialogResult.Yes)
            {
                //create a object of Creational design pattern and show dialogues.
                Creational_Design_Pattern showCourseList = new Creational_Design_Pattern();
                showCourseList.ShowDialog();
            }
        }
        //Design Pattern 2: Behavioral Deisgn Pattern (Admission Test Result and Result Status (i.e. Passed/Failed))
        private void button5_Click(object sender, EventArgs e)
        {
            //Ask user if the user want to enter to this form
            DialogResult dr = MessageBox.Show("This section will show you Admission Test Result.\nDo you want to proceed??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if user want to access this form, must have to click yes
            if (dr == DialogResult.Yes)
            {
                //create a object of Behavioral design pattern and show dialogues.
                Behavioral_Design_Pattern showSectionAndStatus = new Behavioral_Design_Pattern();
                showSectionAndStatus.ShowDialog();
            }
        }
        //Design Pattern 2: Structural Deisgn Pattern (Allotment of Section and feedback on result on the basis of Admission Test Result (i.e. Section-A/B , Very Good))
        private void button4_Click(object sender, EventArgs e)
        {
            //Ask user if the user want to enter to this form
            DialogResult dr = MessageBox.Show("This section will show your Alloted section and student Feedback according to your Admission Test Result.\nDo you want to proceed??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if user want to access this form, must have to click yes
            if (dr == DialogResult.Yes)
            {
                //create a object of Behavioral design pattern and show dialogues.
                Structural_Design_Pattern showAdmissionResult = new Structural_Design_Pattern();
                showAdmissionResult.ShowDialog();
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Close the Form
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
