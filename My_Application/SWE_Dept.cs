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
    public partial class SWE_Dept : Form
    {
        private int year;
        private static string year1 = "          * Software Development 1\n          * Computer Systems\n          * Mathematics for Computer Science\n          * Software Development 2\n          * Computing and Society\n          * Databases\n";
        private static string year2 = "          * Software Development 3\n          * Operating Systems\n          * Algorithms\n          * Software Engineering\n          * Software Architecture and Design\n          * Software Project Management\n";
        private static string year3 = "          * Secure Software Development\n          * Data Engineering\n          * Cyber Security\n          * Formal Methods\n          * Industry Placement\n          * Project\n";
        private static String yearAll = year1 + year2 + year3;
        public SWE_Dept()
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
        private void SWE_Dept_Load(object sender, EventArgs e)
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
