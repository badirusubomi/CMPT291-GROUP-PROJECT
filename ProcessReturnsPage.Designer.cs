namespace CMPT291_GROUP_PROJECT
{
    partial class ProcessReturnsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessReturnsPage));
            this.deletesearchdatagrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.idDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idradio = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.titleradio = new System.Windows.Forms.RadioButton();
            this.titleDelete = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deletesearchdatagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletesearchdatagrid
            // 
            this.deletesearchdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletesearchdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletesearchdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.MovieID,
            this.CopyID,
            this.MovieName,
            this.OrderStatus,
            this.DateFrom,
            this.dateTo});
            this.deletesearchdatagrid.Location = new System.Drawing.Point(3, 272);
            this.deletesearchdatagrid.Name = "deletesearchdatagrid";
            this.deletesearchdatagrid.RowTemplate.Height = 25;
            this.deletesearchdatagrid.Size = new System.Drawing.Size(1055, 157);
            this.deletesearchdatagrid.TabIndex = 14;
            this.deletesearchdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletesearchdatagrid_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idDelete
            // 
            this.idDelete.Enabled = false;
            this.idDelete.Location = new System.Drawing.Point(155, 89);
            this.idDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idDelete.Name = "idDelete";
            this.idDelete.Size = new System.Drawing.Size(278, 23);
            this.idDelete.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "OrderID";
            // 
            // idradio
            // 
            this.idradio.AutoSize = true;
            this.idradio.Location = new System.Drawing.Point(126, 95);
            this.idradio.Name = "idradio";
            this.idradio.Size = new System.Drawing.Size(14, 13);
            this.idradio.TabIndex = 15;
            this.idradio.TabStop = true;
            this.idradio.UseVisualStyleBackColor = true;
            this.idradio.CheckedChanged += new System.EventHandler(this.idradio_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.idradio);
            this.tabPage2.Controls.Add(this.titleradio);
            this.tabPage2.Controls.Add(this.deletesearchdatagrid);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.idDelete);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.titleDelete);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1074, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // titleradio
            // 
            this.titleradio.AutoSize = true;
            this.titleradio.Location = new System.Drawing.Point(126, 58);
            this.titleradio.Name = "titleradio";
            this.titleradio.Size = new System.Drawing.Size(14, 13);
            this.titleradio.TabIndex = 15;
            this.titleradio.TabStop = true;
            this.titleradio.UseVisualStyleBackColor = true;
            this.titleradio.CheckedChanged += new System.EventHandler(this.titleradio_CheckedChanged);
            // 
            // titleDelete
            // 
            this.titleDelete.Enabled = false;
            this.titleDelete.Location = new System.Drawing.Point(155, 52);
            this.titleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleDelete.Name = "titleDelete";
            this.titleDelete.Size = new System.Drawing.Size(278, 23);
            this.titleDelete.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(54, 147);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 462);
            this.tabControl1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(504, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 41);
            this.label9.TabIndex = 21;
            this.label9.Text = "Process Return";
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
            this.button1.Location = new System.Drawing.Point(1035, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1078, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 40);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 98);
            this.panel3.TabIndex = 5;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "Movie ID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "Copy ID";
            this.CopyID.Name = "CopyID";
            this.CopyID.ReadOnly = true;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Title";
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // DateFrom
            // 
            this.DateFrom.HeaderText = "Rent From";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            // 
            // dateTo
            // 
            this.dateTo.HeaderText = "Rent Till";
            this.dateTo.Name = "dateTo";
            this.dateTo.ReadOnly = true;
            // 
            // ProcessReturnsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessReturnsPage";
            this.Text = "ProcessReturnsPage";
            ((System.ComponentModel.ISupportInitialize)(this.deletesearchdatagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView deletesearchdatagrid;
        private Button button3;
        private TextBox idDelete;
        private Label label6;
        private Label label11;
        private RadioButton idradio;
        private TabPage tabPage2;
        private RadioButton titleradio;
        private TextBox titleDelete;
        private TabControl tabControl1;
        private Label label9;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button6;
        private Panel panel3;
        private DataGridViewButtonColumn OrderID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn MovieID;
        private DataGridViewTextBoxColumn CopyID;
        private DataGridViewTextBoxColumn MovieName;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn DateFrom;
        private DataGridViewTextBoxColumn dateTo;
    }
}