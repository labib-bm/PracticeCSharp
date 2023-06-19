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
    public partial class ShowStudentInformation : Form
    {
        string studentFirstName, studentSureName, studentEmail, studentID, studentContactNumber, studentDateOfBirth;
        //All the informations provided by user in Add_Student class will be stored here to display
        public void setInfo(string first, string sure, string email, string id, string contact, String dob)
        {
            this.studentFirstName = first;
            this.studentSureName = sure;
            this.studentEmail = email;
            this.studentID = id;
            this.studentContactNumber = contact;
            this.studentDateOfBirth = dob;
        }
        public ShowStudentInformation()
        {
            InitializeComponent();
        }

        private void ShowStudentInformation_Load(object sender, EventArgs e)
        {
            //assigning values in the textboxes
            label8.Text = studentFirstName;
            label9.Text = studentSureName;
            label10.Text = studentEmail;
            label11.Text = studentID;
            label12.Text = studentContactNumber;
            label13.Text = studentDateOfBirth;
        }
        //To close the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
