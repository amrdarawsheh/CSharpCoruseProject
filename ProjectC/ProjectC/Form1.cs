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
        HRSystemEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new HRSystemEntities();
        }
        
        private void exportTotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = db.Employees.ToList();
                var sw = new System.IO.StreamWriter("Employee.txt");
                if (employees.Count() == 0)
                {
                    sw.WriteLine("No Records");
                }
                else
                {
                    foreach (var emp in employees)
                    {
                        var fullname = emp.firstname + " " + emp.lastname;
                        var depname = emp.Department.Name;
                        var lastPunch = emp.PunchInOuts.LastOrDefault();
                        var status = "";
                        if (lastPunch == null)
                        {
                            status = "unknown";
                        }
                        else if (lastPunch.IsPunchIn == true)
                        {
                            status = "Punched In";
                        }
                        sw.WriteLine("Name: " + fullname);
                        sw.WriteLine("Department: " + depname);
                        sw.WriteLine("Status: " + status);
                    }
                }
                sw.Close();
                MessageBox.Show("Sucessfully Exported to Employees.txt");
                DialogResult dr = MessageBox.Show("Do you want to open the text file?", "Done", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("Employee.txt");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
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
            flag = Check_If_Empty(container1, departmentsddlNew);
            //End of check

            if (flag)
            {
                var employee = new Employee()
                {
                    departmentId = (int)departmentsddlNew.SelectedValue,
                    firstname = first_New.Text.Trim(),
                    lastname = last_New.Text.Trim(),
                };
                db.Employees.Add(employee);
                db.SaveChanges();
                updateTable();
                MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void updateTable()
        {
            dataGridView1.DataSource = typeof(List<Employee>);
            dataGridView1.DataSource = employeeTableAdapter.GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hRSystemDataSet.Employee);
            // TODO: This line of code loads data into the 'hRSystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hRSystemDataSet.Department);
            // TODO: This line of code loads data into the 'hRSystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hRSystemDataSet.Department);
            // TODO: This line of code loads data into the 'hRSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hRSystemDataSet.Employee);

            var employeesList =db.Employees.ToList();
            foreach (var employee in employeesList)
            {
                var lastPunch=employee.PunchInOuts.LastOrDefault();
                var isIn = lastPunch==null || lastPunch.IsPunchOut == null || lastPunch.IsPunchOut == true;
                var button = new Button();
                button.Height = 100;
                button.Width = 150;
                button.Text = employee.firstname + " " + employee.lastname + "\r\n" + "Punch " + (isIn ? "In" : "Out");
                button.Tag = employee.Id;
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);
            }
            container2.Height = 520;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var employeeId = (int)button.Tag;
            var employee = db.Employees.Where(emp=>emp.Id==employeeId).FirstOrDefault();
            var lastPunch=employee.PunchInOuts.LastOrDefault();
            if (lastPunch == null)
            {
                var punch = new PunchInOut()
                {
                    IsPunchIn = true,
                    PunchInDate = DateTime.Now,
                };
                employee.PunchInOuts.Add(punch);
                button.Text = employee.firstname + " " + employee.lastname + "\r\n" + "Punch Out";
            }
            else
            {
                var isIn = lastPunch.IsPunchOut == true;
                if (isIn)
                {
                    var newPunch = new PunchInOut()
                    {
                        IsPunchIn = true,
                        PunchInDate = DateTime.Now
                    };
                    employee.PunchInOuts.Add(newPunch);
                }
                else
                {
                    lastPunch.IsPunchIn = false;
                    lastPunch.IsPunchOut = true;
                    lastPunch.PunchOutDate = DateTime.Now;
                }
                button.Text = employee.firstname + " " + employee.lastname + "\r\n" + "Punch " + (isIn ? "In" : "Out");
            }
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check if ID box is emtpty... 
            if (string.IsNullOrWhiteSpace(edit_Search.Text))
            {
                MessageBox.Show("Please Fill The Empty Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int id = -1;
            if(!int.TryParse(edit_Search.Text,out id))
            {
                MessageBox.Show("Id must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var employee = db.Employees.Where(emp => emp.Id == id).FirstOrDefault();
            bool isEmployeeExist = employee != null;  //for test purposes, delete later mof
            //if found
            if (isEmployeeExist)
            {
                edit_Employee_cont.Visible = true;
                //fill info

                first_Edit.Text = employee.firstname;
                last_Edit.Text = employee.lastname;
                dep_Edit.SelectedValue = employee.departmentId;
                button3.Tag = employee.Id;
            }
            else
            {
                MessageBox.Show("Employee Not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var flag = true; //id true, means all the feilds are filled

            flag = Check_If_Empty(edit_Employee_cont, dep_Edit);

            if (flag)
            {
                var employeeId = (int)button3.Tag;
                var employee = db.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault();
                if (employee != null)
                {
                    employee.firstname = first_Edit.Text;
                    employee.lastname = last_Edit.Text;
                    employee.departmentId = (int)dep_Edit.SelectedValue;
                    db.SaveChanges();
                    updateTable();
                    MessageBox.Show("Employee Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //check if ID feild is empty
            
            if (string.IsNullOrWhiteSpace(del_Search.Text))
            {
                MessageBox.Show("Please Fill The Empty Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            var id = -1;
            if (!int.TryParse(del_Search.Text, out id))
            {
                MessageBox.Show("Id must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var employee = db.Employees.Where(emp => emp.Id == id).FirstOrDefault();

            bool isEmployeeExist = employee != null; //delete later, just for testing
            //if found
            if (isEmployeeExist)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + employee.firstname + " " + employee.lastname + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult==DialogResult.Yes)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    updateTable();
                    MessageBox.Show("Employee Deleted successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }

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

        private void tabControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void importFromtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var count = 0;
            var countSuccess = 0;
            var errors = "";
            try
            {
                var filename = ShowDialog("Please enter name of the import file?", "Import");

                if (!string.IsNullOrEmpty(filename))
                {
                    var sr = new System.IO.StreamReader(filename);
                    while (!sr.EndOfStream)
                    {
                        count++;
                        var Line = sr.ReadLine();
                        var info = Line.Split(',');
                        if (info.Length == 3)
                        {
                            try
                            {

                                var emp = new Employee()
                                {
                                    firstname = info[0].Trim(),
                                    lastname = info[1].Trim(),
                                    departmentId = int.Parse(info[2].Trim())
                                };
                                db.Employees.Add(emp);
                                countSuccess++;
                            }
                            catch (Exception)
                            {
                                errors+=("Something went wrong at line " + count + ": " + Line+"\n");
                            }
                        }
                        else
                        {
                            errors += ("Missing information at line " + count + ": " + Line+"\n");
                        }

                    }
                    sr.Close();
                    if (errors.Length != 0)
                    {
                        MessageBox.Show(errors,"Errors List",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Imported " + countSuccess + " Records to Database Successfully");
                    db.SaveChanges();
                    updateTable(); 
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File Not Found",null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
