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
    public partial class Creational_Design_Pattern : Form
    {
        public Creational_Design_Pattern()
        {
            InitializeComponent();
        }

        private void Creational_Design_Pattern_Load(object sender, EventArgs e)
        {

        }
        //button activities
        private void button1_Click(object sender, EventArgs e)
        {
            //at least two radiobuttons from two group boxes must be selected to get list. If any or both or the group boxes has unselected radio buttons, It will not be execute next form
            if ((radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true) &&
                (radioButton5.Checked == true || radioButton6.Checked == true || radioButton7.Checked == true || radioButton8.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    //if cse is selected it will create a instance of cse department class and will send a parameter year for get a particular year course list.
                    CSE_Dept cse = new CSE_Dept();
                    if (radioButton5.Checked == true)
                    {
                        cse.setYear(1);
                    }
                    else if (radioButton6.Checked == true)
                    {
                        cse.setYear(2);
                    }
                    else if (radioButton7.Checked == true)
                    {
                        cse.setYear(3);
                    }
                    else if (radioButton8.Checked == true)
                    {
                        cse.setYear(4);
                    }
                    cse.ShowDialog();
                }
                else if (radioButton2.Checked == true)
                {
                    Web_Dept web = new Web_Dept();
                    if (radioButton5.Checked == true)
                    {
                        web.setYear(1);
                    }
                    else if (radioButton6.Checked == true)
                    {
                        web.setYear(2);
                    }
                    else if (radioButton7.Checked == true)
                    {
                        web.setYear(3);
                    }
                    else if (radioButton8.Checked == true)
                    {
                        web.setYear(4);
                    }
                    web.ShowDialog();
                }
                else if (radioButton3.Checked == true)
                {
                    SWE_Dept swe = new SWE_Dept();
                    if (radioButton5.Checked == true)
                    {
                        swe.setYear(1);
                    }
                    else if (radioButton6.Checked == true)
                    {
                        swe.setYear(2);
                    }
                    else if (radioButton7.Checked == true)
                    {
                        swe.setYear(3);
                    }
                    else if (radioButton8.Checked == true)
                    {
                        swe.setYear(4);
                    }
                    swe.ShowDialog();
                }
                else if (radioButton4.Checked == true)
                {
                    Cyber_Dept cyber = new Cyber_Dept();
                    if (radioButton5.Checked == true)
                    {
                        cyber.setYear(1);
                    }
                    else if (radioButton6.Checked == true)
                    {
                        cyber.setYear(2);
                    }
                    else if (radioButton7.Checked == true)
                    {
                        cyber.setYear(3);
                    }
                    else if (radioButton8.Checked == true)
                    {
                        cyber.setYear(4);
                    }
                    cyber.ShowDialog();
                }
            }
            //if any or both of the radiobuttons are unselected
            else
            {
                MessageBox.Show("Please select both Department and Year");
            }
            //the form will hide and will visible again for reloading
            this.Hide();
            Creational_Design_Pattern reload = new Creational_Design_Pattern();
            reload.ShowDialog();
        }
        //To close the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
