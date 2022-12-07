namespace CMPT291_GROUP_PROJECT
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeEmails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeGender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeWage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CustomerData = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Address = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.clientEmails = new System.Windows.Forms.DataGridView();
            this.CustomerNames = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerEmails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientEmails)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1150, 98);
            this.panel3.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(104, 103);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 461);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(931, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EmployeeData);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(931, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EmployeeData
            // 
            this.EmployeeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeEmails,
            this.EmployeeAddress,
            this.EmployeeGender,
            this.EmployeeWage});
            this.EmployeeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeData.Location = new System.Drawing.Point(3, 2);
            this.EmployeeData.MultiSelect = false;
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.RowTemplate.Height = 25;
            this.EmployeeData.Size = new System.Drawing.Size(925, 429);
            this.EmployeeData.TabIndex = 0;
            this.EmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeData_CellContentClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Names";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmployeeEmails
            // 
            this.EmployeeEmails.HeaderText = "Emails";
            this.EmployeeEmails.Name = "EmployeeEmails";
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.HeaderText = "Address";
            this.EmployeeAddress.Name = "EmployeeAddress";
            // 
            // EmployeeGender
            // 
            this.EmployeeGender.HeaderText = "Gender";
            this.EmployeeGender.Name = "EmployeeGender";
            // 
            // EmployeeWage
            // 
            this.EmployeeWage.HeaderText = "Wage";
            this.EmployeeWage.Name = "EmployeeWage";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CustomerData);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(931, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CustomerData
            // 
            this.CustomerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn1,
            this.AccountType,
            this.Address,
            this.dataGridViewButtonColumn2});
            this.CustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerData.Location = new System.Drawing.Point(0, 0);
            this.CustomerData.MultiSelect = false;
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.RowTemplate.Height = 25;
            this.CustomerData.Size = new System.Drawing.Size(931, 433);
            this.CustomerData.TabIndex = 1;
            this.CustomerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "CID";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Customer Names";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Account Type";
            this.AccountType.Name = "AccountType";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Emails";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.clientEmails);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(931, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Emails";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // clientEmails
            // 
            this.clientEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clientEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNames,
            this.CustomerEmails,
            this.CustomerID});
            this.clientEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientEmails.Location = new System.Drawing.Point(0, 0);
            this.clientEmails.MultiSelect = false;
            this.clientEmails.Name = "clientEmails";
            this.clientEmails.RowTemplate.Height = 25;
            this.clientEmails.Size = new System.Drawing.Size(931, 433);
            this.clientEmails.TabIndex = 0;
            // 
            // CustomerNames
            // 
            this.CustomerNames.HeaderText = "Customer Names";
            this.CustomerNames.Name = "CustomerNames";
            // 
            // CustomerEmails
            // 
            this.CustomerEmails.HeaderText = "Emails";
            this.CustomerEmails.Name = "CustomerEmails";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CID";
            this.CustomerID.Name = "CustomerID";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientEmails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button6;
        private Button button1;
        private DataGridView EmployeeData;
        private DataGridView CustomerData;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn AccountType;
        private DataGridViewButtonColumn Address;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridView clientEmails;
        private DataGridViewButtonColumn CustomerNames;
        private DataGridViewButtonColumn CustomerEmails;
        private DataGridViewButtonColumn CustomerID;
        private DataGridViewButtonColumn EmployeeID;
        private DataGridViewButtonColumn EmployeeName;
        private DataGridViewButtonColumn EmployeeEmails;
        private DataGridViewButtonColumn EmployeeAddress;
        private DataGridViewButtonColumn EmployeeGender;
        private DataGridViewButtonColumn EmployeeWage;
        private Label label9;
    }
}