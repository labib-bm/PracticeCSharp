using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Application
{
    class AdmissionTestMarks
    {
        //string array list stores different names
        string[] NameList = { "Aziz", "Rocky", "Dave", "McCarter", "Allen", "Monica", "Henry", "Raj", "Kumar", "Mark","Prime",
"Rose","Tracey", "Mike","Crown" };
        String studentName;
        int studentID;
        int physics;
        int chemistry;
        int biology;
        int mathematics;
        int total;
        //setting all values to use
        public void setAll()
        {
            //here we used random values instead of taking user input as mentioned in question to show just result and summary.
            Random choice = new Random();
            int index = choice.Next(NameList.Length);
            studentName = NameList[index];
            Random number = new Random();
            int num = number.Next(100);
            studentID = 1000 + num;
            physics = number.Next(25);
            chemistry = number.Next(25);
            biology = number.Next(25);
            mathematics = number.Next(25);
            total = physics + chemistry + biology + mathematics;
        }
        public string getStudentName()
        {
            return studentName;
        }
        public int getStuentID()
        {
            return studentID;
        }public int getPhysicsMark()
        {
            return physics;
        }public int getChemistryMark()
        {
            return chemistry;
        }public int getBiologyMark()
        {
            return biology;
        }public int getMathematicsMark()
        {
            return mathematics;
        }public int getTotalMark()
        {
            return total;
        }
    }
}
