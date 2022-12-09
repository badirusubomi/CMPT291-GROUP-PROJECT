namespace CMPT291_GROUP_PROJECT
{
    partial class EmployeeReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReports));
            this.fCB = new System.Windows.Forms.CheckBox();
            this.mCB = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.salCB = new System.Windows.Forms.CheckBox();
            this.adrCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sdateCB = new System.Windows.Forms.CheckBox();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ordCO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.srcBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fCB
            // 
            this.fCB.AutoSize = true;
            this.fCB.Location = new System.Drawing.Point(861, 266);
            this.fCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fCB.Name = "fCB";
            this.fCB.Size = new System.Drawing.Size(64, 19);
            this.fCB.TabIndex = 36;
            this.fCB.Text = "Female";
            this.fCB.UseVisualStyleBackColor = true;
            this.fCB.CheckedChanged += new System.EventHandler(this.fCB_CheckedChanged);
            // 
            // mCB
            // 
            this.mCB.AutoSize = true;
            this.mCB.Location = new System.Drawing.Point(861, 231);
            this.mCB.Name = "mCB";
            this.mCB.Size = new System.Drawing.Size(52, 19);
            this.mCB.TabIndex = 35;
            this.mCB.Text = "Male";
            this.mCB.UseVisualStyleBackColor = true;
            this.mCB.CheckedChanged += new System.EventHandler(this.mCB_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salCB
            // 
            this.salCB.AutoSize = true;
            this.salCB.Location = new System.Drawing.Point(861, 207);
            this.salCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salCB.Name = "salCB";
            this.salCB.Size = new System.Drawing.Size(57, 19);
            this.salCB.TabIndex = 33;
            this.salCB.Text = "Salary";
            this.salCB.UseVisualStyleBackColor = true;
            this.salCB.CheckedChanged += new System.EventHandler(this.inhandCB_CheckedChanged);
            // 
            // adrCB
            // 
            this.adrCB.AutoSize = true;
            this.adrCB.Location = new System.Drawing.Point(861, 178);
            this.adrCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adrCB.Name = "adrCB";
            this.adrCB.Size = new System.Drawing.Size(68, 19);
            this.adrCB.TabIndex = 32;
            this.adrCB.Text = "Address";
            this.adrCB.UseVisualStyleBackColor = true;
            this.adrCB.CheckedChanged += new System.EventHandler(this.adrCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(966, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filters";
            // 
            // sdateCB
            // 
            this.sdateCB.AutoSize = true;
            this.sdateCB.Location = new System.Drawing.Point(935, 207);
            this.sdateCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdateCB.Name = "sdateCB";
            this.sdateCB.Size = new System.Drawing.Size(77, 19);
            this.sdateCB.TabIndex = 30;
            this.sdateCB.Text = "Start Date";
            this.sdateCB.UseVisualStyleBackColor = true;
            this.sdateCB.CheckedChanged += new System.EventHandler(this.planCB_CheckedChanged);
            // 
            // emailCB
            // 
            this.emailCB.AutoSize = true;
            this.emailCB.Location = new System.Drawing.Point(935, 178);
            this.emailCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailCB.Name = "emailCB";
            this.emailCB.Size = new System.Drawing.Size(55, 19);
            this.emailCB.TabIndex = 29;
            this.emailCB.Text = "Email";
            this.emailCB.UseVisualStyleBackColor = true;
            this.emailCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CName,
            this.Email,
            this.Gender,
            this.Address,
            this.sDate,
            this.wage});
            this.dataGridView1.Location = new System.Drawing.Point(10, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(814, 296);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Employee ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // sDate
            // 
            this.sDate.HeaderText = "Start Date";
            this.sDate.MinimumWidth = 6;
            this.sDate.Name = "sDate";
            this.sDate.Width = 125;
            // 
            // wage
            // 
            this.wage.HeaderText = "Wage";
            this.wage.MinimumWidth = 6;
            this.wage.Name = "wage";
            this.wage.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 98);
            this.panel3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(484, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 41);
            this.label9.TabIndex = 22;
            this.label9.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1100, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 40);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ordCO
            // 
            this.ordCO.FormattingEnabled = true;
            this.ordCO.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.ordCO.Location = new System.Drawing.Point(1041, 174);
            this.ordCO.Name = "ordCO";
            this.ordCO.Size = new System.Drawing.Size(121, 23);
            this.ordCO.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1041, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sort By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(860, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Filter By";
            // 
            // srcBT
            // 
            this.srcBT.Location = new System.Drawing.Point(1041, 309);
            this.srcBT.Name = "srcBT";
            this.srcBT.Size = new System.Drawing.Size(75, 23);
            this.srcBT.TabIndex = 41;
            this.srcBT.Text = "Apply";
            this.srcBT.UseVisualStyleBackColor = true;
            this.srcBT.Click += new System.EventHandler(this.srcBT_Click);
            // 
            // EmployeeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1220, 477);
            this.Controls.Add(this.srcBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordCO);
            this.Controls.Add(this.fCB);
            this.Controls.Add(this.mCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salCB);
            this.Controls.Add(this.adrCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdateCB);
            this.Controls.Add(this.emailCB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeReports";
            this.Text = "EmployeeReports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox fCB;
        private CheckBox mCB;
        private Button button2;
        private CheckBox salCB;
        private CheckBox adrCB;
        private Label label1;
        private CheckBox sdateCB;
        private CheckBox emailCB;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn sDate;
        private DataGridViewTextBoxColumn wage;
        private Panel panel3;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button6;
        private ComboBox ordCO;
        private Label label2;
        private Label label3;
        private Button srcBT;
    }
}