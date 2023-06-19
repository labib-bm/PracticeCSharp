using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Application
{
    public abstract class status
    {
        int total;
        string statusId;
        protected status checkNext;
        public void SetSuccessor(status checkNext)
        {
            this.checkNext = checkNext;
        }
        public void setStatus(int total, int physics, int chemistry, int biology, int mathematics)
        {
            if (total >= 40 && physics >= 10 && chemistry >= 10 && biology >= 10 && mathematics >= 10)
            {
                this.statusId = "Passed";
            }
            else this.statusId = "Failed";
        }
        public string getStatus()
        {
            return statusId;
        }
        public abstract void HandleRequest(int physics, int chemistry, int biology, int mathematics, int total, int studentID);
    }
    /// <summary>
    /// The 'Fail' class
    /// </summary>
    public class Fail : status
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
    /// <summary>
    /// The 'Pass' class
    /// </summary>
    public class Pass : status
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
