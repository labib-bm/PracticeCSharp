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
    public partial class Cyber_Dept : Form
    {
        private int year;
        private static string year1 = "          * Software Development 1\n          * Computer Systems\n          * Mathematics for Computer Science\n          * Digital Forensics 1\n          * Introduction to Cyber Security\n          * Databases\n";
        private static string year2 = "          * Software Development for Cyber Security\n          * Cyber Law and Regulations\n          * Network Security\n          * Ethical Hacking\n          * Digital Forensics 2\n          * Secure Cloud Computing\n";
        private static string year3 = "          * Data Analytics and Visualisation for Cyber Security\n          * Secure Software Development\n          * Secure Operations and Incident Management\n          * Cyber Risk Management and Governance\n          * Final Year Project\n";
        private static String yearAll = year1 + year2 + year3;
        public Cyber_Dept()
        {
            InitializeComponent();
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        private String GETList()
        {
            if (year == 1)
                return year1;
            else if (year == 2)
                return year2;
            else if (year == 3)
                return year3;
            else
                return yearAll;
        }
        private void Cyber_Dept_Load(object sender, EventArgs e)
        {
            Label head = new Label();
            head.Text = "Course List";
            head.Font = new Font("Calibri", 12);
            head.AutoSize = true;
            this.Controls.Add(head);

            Label head1 = new Label();
            head1.Text = "\n\n" + GETList();
            head1.Font = new Font("Calibri", 11);
            head1.AutoSize = true;
            this.Controls.Add(head1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
