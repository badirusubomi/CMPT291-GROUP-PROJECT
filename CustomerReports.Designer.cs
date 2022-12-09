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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.planCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inhandCB = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.adrCB = new System.Windows.Forms.CheckBox();
            this.mCB = new System.Windows.Forms.CheckBox();
            this.fCB = new System.Windows.Forms.CheckBox();
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
            this.panel3.Size = new System.Drawing.Size(1189, 98);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.inHand});
            this.dataGridView1.Location = new System.Drawing.Point(10, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(814, 296);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // emailCB
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1186, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Email";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // planCB
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1186, 263);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 24);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Plan ID";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // inhandCB
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(979, 212);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 24);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Name";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // adrCB
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(979, 263);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(134, 24);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Movies In Hand";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // mCB
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(979, 316);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // fCB
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1186, 316);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 24);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1359, 564);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planCB);
            this.Controls.Add(this.emailCB);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn inHand;
        private CheckBox emailCB;
        private CheckBox planCB;
        private Label label1;
        private CheckBox inhandCB;
        private Button button2;
        private CheckBox adrCB;
        private CheckBox mCB;
        private CheckBox fCB;
    }
}