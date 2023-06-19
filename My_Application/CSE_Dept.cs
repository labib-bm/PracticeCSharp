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
    public partial class CSE_Dept : Form
    {
        //course lists for each year
        private int year;
        private static string year1 = "          * Software Development 1\n          * Computer Systems\n          * Mathematics for Computer Science\n          * Software Development 2\n          * Computing and Society\n          * Databases\n";
        private static string year2 = "          * Software Development 3\n          * Operating Systems\n          * Algorithms\n          * Software Engineering\n          * Data Science\n          * Artificial Intelligence\n";
        private static string year3 = "          * Machine Learning\n          * Data Engineering\n          * Cyber Security\n          * Data Visualisation\n          * Final-Year Project";
        private static String yearAll = year1 + year2 + year3;
        public CSE_Dept()
        {
            InitializeComponent();
        }
        //set year for get particular year show list
        public void setYear(int year)
        {
            this.year = year;
        }
        //course list string for corresponding year
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
        private void CSE_Dept_Load(object sender, EventArgs e)
        {
            //Headline
            Label head = new Label();
            head.Text = "Course List";
            head.Font = new Font("Calibri", 12);
            head.AutoSize = true;
            this.Controls.Add(head);
            //Course List
            Label head1 = new Label();
            head1.Text = "\n\n" + GETList();
            head1.Font = new Font("Calibri", 11);
            head1.AutoSize = true;
            this.Controls.Add(head1);
        }
        //To close the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
