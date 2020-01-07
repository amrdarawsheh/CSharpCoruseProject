using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void exportTotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_ResizeEnd_1(object sender, EventArgs e)
        {
            container1.Left = Width / 2 - container1.Width / 2;
            container2.Left = Width / 2 - container2.Width / 2;
            container3.Left = Width / 2 - container3.Width / 2;


            seperator1.Width = Width;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true; //if true, means all feilds are filled 
            //Check for empty textboxes or unselected departments
            flag = Check_If_Empty(container1, Dep_new);
            //End of check

            if (flag)
            {
                MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            container2.Height = 520;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check if ID box is emtpty... 
            if (string.IsNullOrWhiteSpace(edit_Search.Text))
            {
                MessageBox.Show("Please Fill The Empty Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            bool test = true; //for test purposes, delete later mof
            //if found
            if (test)
            {
                edit_Employee_cont.Visible = true;
                //fill info

                first_Edit.Text = "Mofen";
                last_Edit.Text = "Mafyofen";
                ID_Edit.Text = "2015265";
                dep_Edit.Text = "Dep1";
            }
            else
            {
                edit_Employee_cont.Visible = false;
                MessageBox.Show("Employee Not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var flag = true; //id true, means all the feilds are filled

            flag = Check_If_Empty(edit_Employee_cont, dep_Edit);

            if (flag)
            {
                MessageBox.Show("Employee Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //check if ID feild is empty
            if (string.IsNullOrWhiteSpace(del_Search.Text))
            {
                MessageBox.Show("Please Fill The Empty Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }


            bool test = false; //delete later, just for testing
            //if found
            if (test)
            {
                //delete Employee
                // end of deelte employee code
                MessageBox.Show("Employee Deleted successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
            else
            {
              MessageBox.Show("Employee Not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool Check_If_Empty(Panel p,ComboBox b)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Please Fill The Empty Textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                    }
                }
            }
            if (b.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
    }
}
