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
    public partial class Structural_Design_Pattern : Form
    {
        //initializing values
        string studentName = "Rocky";
        int studentID = 1234;
        int physics = 20;
        int chemistry = 20;
        int biology = 20;
        int mathematics = 20;
        int total = 80;
        string status = "passed";
        public Structural_Design_Pattern()
        {
            InitializeComponent();
        }
        //objec created for admissiontestmarks and instance used to get information from that class
        public void getiInformation()
        {
            AdmissionTestMarks getAll = new AdmissionTestMarks();
            getAll.setAll();
            //এখানে কিন্তু আগের মতো নাম নাম্বার আইডি সব নিয়া আসছি। কিন্ত্য প্রিন্ট করি নাই...
            studentName = getAll.getStudentName();
            studentID = getAll.getStuentID();
            physics = getAll.getPhysicsMark();
            chemistry = getAll.getChemistryMark();
            biology = getAll.getBiologyMark();
            mathematics = getAll.getMathematicsMark();
            total = getAll.getTotalMark();
        }

        private void Structural_Design_Pattern_Load(object sender, EventArgs e)
        {
            //assigning values in label boxes
            getiInformation();
            //নাম প্রিন্ট
            label6.Text = studentName;
            //আইডী প্রিন্ট
            label7.Text = studentID.ToString();
            dataForm id = new setStudentMarks(physics,chemistry,biology,mathematics);
            id.getInformation();
            total = physics + chemistry + biology + mathematics;
            label8.Text = id.getStatus(); ;
            label9.Text = id.getSection(); ;
            label10.Text = id.getFeedback();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check marks of each subject in the message. It will not visible in the form. If user want to see details, he/she will click on the button
            string message = "Physics:" + physics + "\nChemistry: " +chemistry+ "\nBiology: "+biology+"\nMathematics: "+mathematics + "\nTotal: " + total;
            string title = "Marks";
            MessageBox.Show(message,title);
        }
    }
    //Store student informations (Name, Obtained marks for each subject). Return total marks, Section and Feedback)
    public class studentMarks
    {
        int physics;
        int chemistry;
        int biology;
        int mathematics;
        int marks;
        int total;
        string status;
        string section;
        string Feedback;
        //assigning values in this class
        public int getObtainedMarks(int physics, int chemistry, int biology, int mathematics)
        {
            this.physics = physics;
            this.chemistry = chemistry;
            this.biology = biology;
            this.mathematics = mathematics;
            this.total = physics + chemistry + biology + mathematics;
            return total;
        }
        //getting section allotment on the basis of marks
        public string getStudentSection(int physics, int chemistry, int biology, int mathematics)
        {
            int total = physics + chemistry + biology + mathematics;
            if (total < 40 || physics < 10 || chemistry < 10 || biology < 10 || mathematics < 10) {
                status = "Failed"; section = "Failed";
            }
            else if (total >= 40 && physics >= 10 && chemistry >= 10 && biology >= 10 && mathematics >= 10)
            {
                status = "Passed";
                if (physics >= 20 && chemistry >= 20 && biology >= 20 && mathematics >= 20) section = "Section A";
                else if (physics >= 20 && chemistry >= 20 && biology < 20 && mathematics >= 20) section = "Section B";
                else if (physics >= 20 && chemistry < 20 && biology < 20 && mathematics >= 20) section = "Section C";
                else if (physics >= 20 && chemistry >= 20 && biology < 20 && mathematics < 20) section = "Section D";
                else if (physics < 20 && chemistry >= 20 && biology >= 20 && mathematics < 20) section = "Section E";
                else if (physics < 20 && chemistry < 20 && biology < 20 && mathematics >= 20) section = "Section F";
                else if (physics >= 20 && chemistry < 20 && biology < 20 && mathematics < 20) section = "Section G";
                else if (physics < 20 && chemistry >= 20 && biology < 20 && mathematics < 20) section = "Section H";
                else if (physics < 20 && chemistry < 20 && biology >= 20 && mathematics < 20) section = "Section I";
                else if (physics < 20 && chemistry < 20 && biology < 20 && mathematics < 20) section = "Section J";
            }
            return section;
        }
        //feedback on performance in admission test
        public string getStudentFeedback(string StudentSection)
        {
            if (StudentSection == "Failed") Feedback = "Try next Time";
            else if (StudentSection == "Section A") Feedback = "Very dedicated";
            else if (StudentSection == "Section B") Feedback = "Dedicated";
            else if (StudentSection == "Section C") Feedback = "Dedicated";
            else if (StudentSection == "Section D") Feedback = "Good";
            else if (StudentSection == "Section E") Feedback = "Good";
            else if (StudentSection == "Section F") Feedback = "Average";
            else if (StudentSection == "Section G") Feedback = "Average";
            else if (StudentSection == "Section H") Feedback = "Average";
            else if (StudentSection == "Section I") Feedback = "Average";
            else if (StudentSection == "Section J") Feedback = "Need to improve";

            return Feedback;
        }
        //sending status as return
        public string getStatus()
        {
            return status;
        }
    }
    //Data Information class
    public class dataForm
    {
        public virtual void getInformation()
        {
            Console.WriteLine("Student's Information");
            Console.WriteLine("\n");
        }
        public virtual string getSection()
        {
            return null;
        }
        public virtual string getFeedback()
        {
            return null;
        }
        public virtual string getStatus()
        {
            return null;
        }

    }
    //Implementing dataform
    public class setStudentMarks : dataForm
    {
        int studentMark;
        private int physics;
        private int chemistry;
        private int biology;
        private int mathematics;
        public string studentSection;
        public string studentFeedback;
        public string studentStatus;
        public setStudentMarks(int physics, int chemistry, int biology, int mathematics)
        {
            this.physics = physics;
            this.chemistry = chemistry;
            this.biology = biology;
            this.mathematics = mathematics;
        }
        public override void getInformation()
        {
            studentMarks data = new studentMarks();
            //getting informations from studentMarks class by getter
            studentMark = data.getObtainedMarks(physics, chemistry, biology, mathematics);
            studentSection = data.getStudentSection(physics, chemistry, biology, mathematics);
            studentFeedback = data.getStudentFeedback(studentSection);
            studentStatus = data.getStatus();
        }
        public override string getSection()
        {
            return studentSection;
        }
        public override string getFeedback()
        {
            return studentFeedback;
        }
        public override string getStatus()
        {
            return studentStatus;
        }
    }
}
