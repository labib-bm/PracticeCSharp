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
    public partial class Behavioral_Design_Pattern : Form
    {
        //Initial values
        string studentName ="Rocky";
        int studentID=1234;
        int physics=20;
        int chemistry=20;
        int biology=20;
        int mathematics=20;
        int total=80;
        string status = "passed";
        public Behavioral_Design_Pattern()
        {
            InitializeComponent();
        }
        public void getiInformation()
        {
            //creating object for admissiontestmarks class for getting admission test examnee and marks.
            AdmissionTestMarks getAll = new AdmissionTestMarks();
            //calling metthod for setting info
            getAll.setAll();
            //storing information in this class variables
            studentName = getAll.getStudentName();
            studentID = getAll.getStuentID();
            physics = getAll.getPhysicsMark();
            chemistry = getAll.getChemistryMark();
            biology = getAll.getBiologyMark();
            mathematics = getAll.getMathematicsMark();
            total = getAll.getTotalMark();
        }
        private void Behavioral_Design_Pattern_Load(object sender, EventArgs e)
        {
            //assigning values in labels
            getiInformation();
            label9.Text = studentName;
            label10.Text = studentID.ToString();
            label11.Text = physics.ToString();
            label12.Text = chemistry.ToString();
            label13.Text = biology.ToString();
            label14.Text = mathematics.ToString();
            label15.Text = total.ToString();
            //created objects for classes to perform operations and get admission test result status (pass or fail)
            status s0 = new Fail();
            status s1 = new Pass();
            s0.SetSuccessor(s1);
            s0.HandleRequest(physics, chemistry, biology, mathematics, total, studentID);
            s0.setStatus(total, physics, chemistry, biology, mathematics);
            status = s0.getStatus();
            label16.Text = status.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    //abstract class used for design pattern purpose
    public abstract class studentStatus
    {
        int total;
        string statusId;
        protected status checkNext;
        //successor uses for checking next options
        public void SetSuccessor(status checkNext)
        {
            this.checkNext = checkNext;
        }
        //setting status according to result
        public void setStatus(int total, int physics, int chemistry, int biology, int mathematics)
        {
            if (total >= 40 && physics >= 10 && chemistry >= 10 && biology >= 10 && mathematics >= 10)
            {
                this.statusId = "Passed";
            }
            else this.statusId = "Failed";
        }
        //returning status
        public string getStatus()
        {
            return statusId;
        }
        public abstract void HandleRequest(int physics, int chemistry, int biology, int mathematics, int total, int studentID);
    }
    /// The 'Fail' class
    // to check if the student has failed or not
    public class resultFail : status
    {
        string statusId;
        int id;
        public override void HandleRequest(int physics, int chemistry, int biology, int mathematics, int total, int studentID)
        {
            if (total < 40 || physics < 10 || chemistry < 10 || biology < 10 || mathematics < 10)
            {
                //Console.WriteLine("{0} status: {1}", studentID, "Failed");
            }
            else if (checkNext != null)
            {
                checkNext.HandleRequest(physics, chemistry, biology, mathematics, total, studentID);
            }
        }
        public void setStatus(int total)
        {
            this.statusId = "Failed";
        }
        public string getStatus()
        {
            return statusId;
        }
    }
    /// The 'Pass' class
    // to check if the student has Passed
    public class resultPass : status
    {
        int id;
        string statusId;
        public override void HandleRequest(int physics, int chemistry, int biology, int mathematics, int total, int studentID)
        {
            if (total >= 40)
            {
                //Console.WriteLine("{0} status: {1}", studentID, "Passed");
            }
            else if (checkNext != null)
            {
                checkNext.HandleRequest(physics, chemistry, biology, mathematics, total, studentID);
            }
        }
        public void setStatus(int total)
        {
            this.statusId = "Passed";
        }
        public string getStatus()
        {
            return statusId;
        }
    }
}
