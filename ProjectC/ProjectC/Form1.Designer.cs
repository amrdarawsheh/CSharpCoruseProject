namespace ProjectC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.container1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.header1 = new System.Windows.Forms.Label();
            this.last_New = new System.Windows.Forms.TextBox();
            this.Dep_new = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.first_New = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_New = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.container2 = new System.Windows.Forms.Panel();
            this.separetor1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.edit_Employee_cont = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_Edit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.first_Edit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.last_Edit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dep_Edit = new System.Windows.Forms.ComboBox();
            this.seperator1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.edit_Search = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.container3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.del_Search = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.container1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.container2.SuspendLayout();
            this.edit_Employee_cont.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.container3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTotxtToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exportTotxtToolStripMenuItem
            // 
            this.exportTotxtToolStripMenuItem.Name = "exportTotxtToolStripMenuItem";
            this.exportTotxtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportTotxtToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.exportTotxtToolStripMenuItem.Text = "Export to .txt";
            this.exportTotxtToolStripMenuItem.Click += new System.EventHandler(this.exportTotxtToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 685);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List Employee Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 646);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.container1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // container1
            // 
            this.container1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container1.Controls.Add(this.pictureBox1);
            this.container1.Controls.Add(this.label12);
            this.container1.Controls.Add(this.label13);
            this.container1.Controls.Add(this.button1);
            this.container1.Controls.Add(this.header1);
            this.container1.Controls.Add(this.last_New);
            this.container1.Controls.Add(this.Dep_new);
            this.container1.Controls.Add(this.label1);
            this.container1.Controls.Add(this.label3);
            this.container1.Controls.Add(this.label4);
            this.container1.Controls.Add(this.first_New);
            this.container1.Controls.Add(this.label2);
            this.container1.Controls.Add(this.ID_New);
            this.container1.Location = new System.Drawing.Point(3, 6);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(862, 521);
            this.container1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(-4, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(872, 2);
            this.label12.TabIndex = 32;
            this.label12.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.Location = new System.Drawing.Point(340, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 39);
            this.label13.TabIndex = 30;
            this.label13.Text = "New Employee";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(365, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.header1.Location = new System.Drawing.Point(317, 136);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(253, 29);
            this.header1.TabIndex = 2;
            this.header1.Text = "Employee Infortmation";
            // 
            // last_New
            // 
            this.last_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_New.Location = new System.Drawing.Point(365, 248);
            this.last_New.Name = "last_New";
            this.last_New.Size = new System.Drawing.Size(162, 26);
            this.last_New.TabIndex = 9;
            // 
            // Dep_new
            // 
            this.Dep_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Dep_new.FormattingEnabled = true;
            this.Dep_new.Items.AddRange(new object[] {
            "Dep1",
            "Dep2",
            "Dep3"});
            this.Dep_new.Location = new System.Drawing.Point(104, 359);
            this.Dep_new.Name = "Dep_new";
            this.Dep_new.Size = new System.Drawing.Size(162, 28);
            this.Dep_new.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(100, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(100, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(361, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // first_New
            // 
            this.first_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_New.Location = new System.Drawing.Point(104, 248);
            this.first_New.Name = "first_New";
            this.first_New.Size = new System.Drawing.Size(162, 26);
            this.first_New.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(607, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // ID_New
            // 
            this.ID_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID_New.Location = new System.Drawing.Point(611, 248);
            this.ID_New.Name = "ID_New";
            this.ID_New.Size = new System.Drawing.Size(162, 26);
            this.ID_New.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.container2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(900, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // container2
            // 
            this.container2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container2.Controls.Add(this.pictureBox2);
            this.container2.Controls.Add(this.separetor1);
            this.container2.Controls.Add(this.label16);
            this.container2.Controls.Add(this.edit_Employee_cont);
            this.container2.Controls.Add(this.seperator1);
            this.container2.Controls.Add(this.label9);
            this.container2.Controls.Add(this.button2);
            this.container2.Controls.Add(this.label8);
            this.container2.Controls.Add(this.edit_Search);
            this.container2.Location = new System.Drawing.Point(0, 3);
            this.container2.Name = "container2";
            this.container2.Size = new System.Drawing.Size(897, 631);
            this.container2.TabIndex = 18;
            // 
            // separetor1
            // 
            this.separetor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separetor1.Location = new System.Drawing.Point(8, 110);
            this.separetor1.Name = "separetor1";
            this.separetor1.Size = new System.Drawing.Size(872, 2);
            this.separetor1.TabIndex = 35;
            this.separetor1.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label16.Location = new System.Drawing.Point(351, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(237, 39);
            this.label16.TabIndex = 34;
            this.label16.Text = "Edit Employee";
            // 
            // edit_Employee_cont
            // 
            this.edit_Employee_cont.Controls.Add(this.label5);
            this.edit_Employee_cont.Controls.Add(this.ID_Edit);
            this.edit_Employee_cont.Controls.Add(this.label10);
            this.edit_Employee_cont.Controls.Add(this.button3);
            this.edit_Employee_cont.Controls.Add(this.label11);
            this.edit_Employee_cont.Controls.Add(this.first_Edit);
            this.edit_Employee_cont.Controls.Add(this.label7);
            this.edit_Employee_cont.Controls.Add(this.last_Edit);
            this.edit_Employee_cont.Controls.Add(this.label6);
            this.edit_Employee_cont.Controls.Add(this.dep_Edit);
            this.edit_Employee_cont.Location = new System.Drawing.Point(8, 272);
            this.edit_Employee_cont.Name = "edit_Employee_cont";
            this.edit_Employee_cont.Size = new System.Drawing.Size(865, 343);
            this.edit_Employee_cont.TabIndex = 29;
            this.edit_Employee_cont.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(85, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "First Name";
            // 
            // ID_Edit
            // 
            this.ID_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID_Edit.Location = new System.Drawing.Point(596, 120);
            this.ID_Edit.Name = "ID_Edit";
            this.ID_Edit.Size = new System.Drawing.Size(162, 26);
            this.ID_Edit.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(592, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(361, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 48);
            this.button3.TabIndex = 26;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(331, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Edit Employee";
            // 
            // first_Edit
            // 
            this.first_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_Edit.Location = new System.Drawing.Point(89, 120);
            this.first_Edit.Name = "first_Edit";
            this.first_Edit.Size = new System.Drawing.Size(162, 26);
            this.first_Edit.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(346, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Last Name";
            // 
            // last_Edit
            // 
            this.last_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_Edit.Location = new System.Drawing.Point(350, 120);
            this.last_Edit.Name = "last_Edit";
            this.last_Edit.Size = new System.Drawing.Size(162, 26);
            this.last_Edit.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(85, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Department";
            // 
            // dep_Edit
            // 
            this.dep_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dep_Edit.FormattingEnabled = true;
            this.dep_Edit.Items.AddRange(new object[] {
            "Dep1",
            "Dep2",
            "Dep3"});
            this.dep_Edit.Location = new System.Drawing.Point(89, 231);
            this.dep_Edit.Name = "dep_Edit";
            this.dep_Edit.Size = new System.Drawing.Size(162, 28);
            this.dep_Edit.TabIndex = 25;
            // 
            // seperator1
            // 
            this.seperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator1.Location = new System.Drawing.Point(5, 267);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(872, 2);
            this.seperator1.TabIndex = 27;
            this.seperator1.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(314, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Search for Employee";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(498, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(217, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // edit_Search
            // 
            this.edit_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edit_Search.Location = new System.Drawing.Point(221, 213);
            this.edit_Search.Name = "edit_Search";
            this.edit_Search.Size = new System.Drawing.Size(162, 26);
            this.edit_Search.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.container3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(900, 652);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Employee";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // container3
            // 
            this.container3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container3.Controls.Add(this.pictureBox3);
            this.container3.Controls.Add(this.label17);
            this.container3.Controls.Add(this.label18);
            this.container3.Controls.Add(this.label14);
            this.container3.Controls.Add(this.button5);
            this.container3.Controls.Add(this.label20);
            this.container3.Controls.Add(this.del_Search);
            this.container3.Location = new System.Drawing.Point(8, 4);
            this.container3.Name = "container3";
            this.container3.Size = new System.Drawing.Size(849, 511);
            this.container3.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(-2, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(872, 2);
            this.label17.TabIndex = 38;
            this.label17.Text = " ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label18.Location = new System.Drawing.Point(319, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 39);
            this.label18.TabIndex = 37;
            this.label18.Text = "Delete Employee";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(310, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 29);
            this.label14.TabIndex = 17;
            this.label14.Text = "Delete Employee";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(455, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 48);
            this.button5.TabIndex = 17;
            this.button5.Text = "Delete Employee";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(199, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "ID";
            // 
            // del_Search
            // 
            this.del_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.del_Search.Location = new System.Drawing.Point(203, 259);
            this.del_Search.Name = "del_Search";
            this.del_Search.Size = new System.Drawing.Size(162, 26);
            this.del_Search.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(900, 652);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Punch in/out";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectC.Properties.Resources.new_User;
            this.pictureBox1.Location = new System.Drawing.Point(258, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectC.Properties.Resources.Edit_User;
            this.pictureBox2.Location = new System.Drawing.Point(271, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectC.Properties.Resources.remove_user1;
            this.pictureBox3.Location = new System.Drawing.Point(236, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 716);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "HR System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.container1.ResumeLayout(false);
            this.container1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.container2.ResumeLayout(false);
            this.container2.PerformLayout();
            this.edit_Employee_cont.ResumeLayout(false);
            this.edit_Employee_cont.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.container3.ResumeLayout(false);
            this.container3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox Dep_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_New;
        private System.Windows.Forms.TextBox ID_New;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox last_New;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel container1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel container2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edit_Search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label seperator1;
        private System.Windows.Forms.Panel container3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox del_Search;
        private System.Windows.Forms.Panel edit_Employee_cont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_Edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox first_Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox last_Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dep_Edit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label separetor1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

