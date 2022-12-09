namespace CMPT291_GROUP_PROJECT
{
    partial class CustomerReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReports));
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clrBT = new System.Windows.Forms.Button();
            this.apBT = new System.Windows.Forms.Button();
            this.sdRB = new System.Windows.Forms.RadioButton();
            this.edRB = new System.Windows.Forms.RadioButton();
            this.adrRB = new System.Windows.Forms.RadioButton();
            this.ihRB = new System.Windows.Forms.RadioButton();
            this.mRB = new System.Windows.Forms.RadioButton();
            this.emRB = new System.Windows.Forms.RadioButton();
            this.plRB = new System.Windows.Forms.RadioButton();
            this.fRB = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1359, 98);
            this.panel3.TabIndex = 15;
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
            this.Plan,
            this.inHand,
            this.sDate,
            this.eDate});
            this.dataGridView1.Location = new System.Drawing.Point(10, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(814, 296);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(955, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clrBT
            // 
            this.clrBT.Location = new System.Drawing.Point(358, 470);
            this.clrBT.Name = "clrBT";
            this.clrBT.Size = new System.Drawing.Size(75, 23);
            this.clrBT.TabIndex = 24;
            this.clrBT.Text = "Clear";
            this.clrBT.UseVisualStyleBackColor = true;
            this.clrBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // apBT
            // 
            this.apBT.Location = new System.Drawing.Point(942, 401);
            this.apBT.Name = "apBT";
            this.apBT.Size = new System.Drawing.Size(75, 23);
            this.apBT.TabIndex = 25;
            this.apBT.Text = "Apply";
            this.apBT.UseVisualStyleBackColor = true;
            this.apBT.Click += new System.EventHandler(this.apBT_Click);
            // 
            // sdRB
            // 
            this.sdRB.AutoSize = true;
            this.sdRB.Location = new System.Drawing.Point(858, 349);
            this.sdRB.Name = "sdRB";
            this.sdRB.Size = new System.Drawing.Size(76, 19);
            this.sdRB.TabIndex = 26;
            this.sdRB.TabStop = true;
            this.sdRB.Text = "Start Date";
            this.sdRB.UseVisualStyleBackColor = true;
            // 
            // edRB
            // 
            this.edRB.AutoSize = true;
            this.edRB.Location = new System.Drawing.Point(1033, 349);
            this.edRB.Name = "edRB";
            this.edRB.Size = new System.Drawing.Size(84, 19);
            this.edRB.TabIndex = 27;
            this.edRB.TabStop = true;
            this.edRB.Text = "Expiry Date";
            this.edRB.UseVisualStyleBackColor = true;
            // 
            // adrRB
            // 
            this.adrRB.AutoSize = true;
            this.adrRB.Location = new System.Drawing.Point(858, 194);
            this.adrRB.Name = "adrRB";
            this.adrRB.Size = new System.Drawing.Size(67, 19);
            this.adrRB.TabIndex = 28;
            this.adrRB.TabStop = true;
            this.adrRB.Text = "Address";
            this.adrRB.UseVisualStyleBackColor = true;
            // 
            // ihRB
            // 
            this.ihRB.AutoSize = true;
            this.ihRB.Location = new System.Drawing.Point(858, 245);
            this.ihRB.Name = "ihRB";
            this.ihRB.Size = new System.Drawing.Size(108, 19);
            this.ihRB.TabIndex = 29;
            this.ihRB.TabStop = true;
            this.ihRB.Text = "Movies In Hand";
            this.ihRB.UseVisualStyleBackColor = true;
            // 
            // mRB
            // 
            this.mRB.AutoSize = true;
            this.mRB.Location = new System.Drawing.Point(858, 297);
            this.mRB.Name = "mRB";
            this.mRB.Size = new System.Drawing.Size(51, 19);
            this.mRB.TabIndex = 30;
            this.mRB.TabStop = true;
            this.mRB.Text = "Male";
            this.mRB.UseVisualStyleBackColor = true;
            // 
            // emRB
            // 
            this.emRB.AutoSize = true;
            this.emRB.Location = new System.Drawing.Point(1033, 194);
            this.emRB.Name = "emRB";
            this.emRB.Size = new System.Drawing.Size(54, 19);
            this.emRB.TabIndex = 31;
            this.emRB.TabStop = true;
            this.emRB.Text = "Email";
            this.emRB.UseVisualStyleBackColor = true;
            // 
            // plRB
            // 
            this.plRB.AutoSize = true;
            this.plRB.Location = new System.Drawing.Point(1033, 245);
            this.plRB.Name = "plRB";
            this.plRB.Size = new System.Drawing.Size(62, 19);
            this.plRB.TabIndex = 32;
            this.plRB.TabStop = true;
            this.plRB.Text = "Plan ID";
            this.plRB.UseVisualStyleBackColor = true;
            // 
            // fRB
            // 
            this.fRB.AutoSize = true;
            this.fRB.Location = new System.Drawing.Point(1033, 297);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(63, 19);
            this.fRB.TabIndex = 33;
            this.fRB.TabStop = true;
            this.fRB.Text = "Female";
            this.fRB.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Customer ID";
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
            // Plan
            // 
            this.Plan.HeaderText = "Plan ID";
            this.Plan.MinimumWidth = 6;
            this.Plan.Name = "Plan";
            this.Plan.Width = 125;
            // 
            // inHand
            // 
            this.inHand.HeaderText = "Movies In Hand";
            this.inHand.MinimumWidth = 6;
            this.inHand.Name = "inHand";
            this.inHand.Width = 125;
            // 
            // sDate
            // 
            this.sDate.HeaderText = "Date Joined";
            this.sDate.Name = "sDate";
            // 
            // eDate
            // 
            this.eDate.HeaderText = "Expiry Date";
            this.eDate.Name = "eDate";
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1359, 564);
            this.Controls.Add(this.fRB);
            this.Controls.Add(this.plRB);
            this.Controls.Add(this.emRB);
            this.Controls.Add(this.mRB);
            this.Controls.Add(this.ihRB);
            this.Controls.Add(this.adrRB);
            this.Controls.Add(this.edRB);
            this.Controls.Add(this.sdRB);
            this.Controls.Add(this.apBT);
            this.Controls.Add(this.clrBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerReports";
            this.Text = "CustomerReports";
            this.Load += new System.EventHandler(this.CustomerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label9;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label1;
        private Button clrBT;
        private Button apBT;
        private RadioButton sdRB;
        private RadioButton edRB;
        private RadioButton adrRB;
        private RadioButton ihRB;
        private RadioButton mRB;
        private RadioButton emRB;
        private RadioButton plRB;
        private RadioButton fRB;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn inHand;
        private DataGridViewTextBoxColumn sDate;
        private DataGridViewTextBoxColumn eDate;
    }
}