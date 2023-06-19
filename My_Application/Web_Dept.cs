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
    public partial class Web_Dept : Form
    {
        private int year;
        private static string year1 = "          * Software Design 1\n          * Software Design 2\n          * Introduction to Digital Media\n          * Digital Imaging\n          * Basic Web Design\n          * Databases\n";
        private static string year2 = "          * Software Development 3\n          * Advanced Web Design\n          * Digital Methods 2\n          * Software Engineering\n          * Mobile App Design\n          * Digital Gaming\n";
        private static string year3 = "          * User Experience (UX)\n          * Digital Project Management\n          * Cyber Security\n          * Doing Visual Research\n          * Work Placement\n          * Final Year Project\n";
        private static String yearAll = year1 + year2 + year3;
        public Web_Dept()
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
        private void Web_Dept_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
