namespace CMPT291_GROUP_PROJECT
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearReleasedBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idradio = new System.Windows.Forms.RadioButton();
            this.titleradio = new System.Windows.Forms.RadioButton();
            this.deletesearchdatagrid = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.idDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletesearchdatagrid)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1150, 98);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(504, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 41);
            this.label9.TabIndex = 21;
            this.label9.Text = "Edit Movies";
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
            this.button1.Location = new System.Drawing.Point(1057, 67);
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
            this.tabControl1.Location = new System.Drawing.Point(56, 131);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 462);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.genreBox);
            this.tabPage1.Controls.Add(this.feeBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.ratingBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.yearReleasedBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.titleBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1074, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Movie";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Romance",
            "Thriller",
            "Documentary"});
            this.genreBox.Location = new System.Drawing.Point(145, 64);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(213, 23);
            this.genreBox.TabIndex = 5;
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(727, 26);
            this.feeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(278, 23);
            this.feeBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fee";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(922, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(145, 92);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(278, 23);
            this.ratingBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rating";
            // 
            // yearReleasedBox
            // 
            this.yearReleasedBox.Location = new System.Drawing.Point(145, 124);
            this.yearReleasedBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearReleasedBox.Name = "yearReleasedBox";
            this.yearReleasedBox.Size = new System.Drawing.Size(278, 23);
            this.yearReleasedBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year Released";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(145, 29);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(278, 23);
            this.titleBox.TabIndex = 1;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.idradio);
            this.tabPage2.Controls.Add(this.titleradio);
            this.tabPage2.Controls.Add(this.deletesearchdatagrid);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.idDelete);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.titleDelete);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1074, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Movie";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // idradio
            // 
            this.idradio.AutoSize = true;
            this.idradio.Location = new System.Drawing.Point(123, 93);
            this.idradio.Name = "idradio";
            this.idradio.Size = new System.Drawing.Size(14, 13);
            this.idradio.TabIndex = 15;
            this.idradio.TabStop = true;
            this.idradio.UseVisualStyleBackColor = true;
            this.idradio.CheckedChanged += new System.EventHandler(this.idradio_CheckedChanged);
            // 
            // titleradio
            // 
            this.titleradio.AutoSize = true;
            this.titleradio.Location = new System.Drawing.Point(123, 56);
            this.titleradio.Name = "titleradio";
            this.titleradio.Size = new System.Drawing.Size(14, 13);
            this.titleradio.TabIndex = 15;
            this.titleradio.TabStop = true;
            this.titleradio.UseVisualStyleBackColor = true;
            this.titleradio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // deletesearchdatagrid
            // 
            this.deletesearchdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletesearchdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.deletesearchdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletesearchdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.MovieName,
            this.MovieType,
            this.fee,
            this.Year,
            this.MovieRating});
            this.deletesearchdatagrid.Location = new System.Drawing.Point(3, 272);
            this.deletesearchdatagrid.Name = "deletesearchdatagrid";
            this.deletesearchdatagrid.RowTemplate.Height = 25;
            this.deletesearchdatagrid.Size = new System.Drawing.Size(1055, 98);
            this.deletesearchdatagrid.TabIndex = 14;
            this.deletesearchdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletesearchdatagrid_CellContentClick);
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "ID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovieID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Title";
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MovieType
            // 
            this.MovieType.HeaderText = "Genre";
            this.MovieType.Name = "MovieType";
            this.MovieType.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.HeaderText = "Fee";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // MovieRating
            // 
            this.MovieRating.HeaderText = "Rating";
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.ReadOnly = true;
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
            this.label6.Location = new System.Drawing.Point(33, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Movie ID";
            // 
            // titleDelete
            // 
            this.titleDelete.Enabled = false;
            this.titleDelete.Location = new System.Drawing.Point(155, 52);
            this.titleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleDelete.Name = "titleDelete";
            this.titleDelete.Size = new System.Drawing.Size(278, 23);
            this.titleDelete.TabIndex = 12;
            this.titleDelete.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Title";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletesearchdatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button1;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox titleBox;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox yearReleasedBox;
        private Label label3;
        private Label label2;
        private TextBox ratingBox;
        private Label label4;
        private TextBox feeBox;
        private Label label5;
        private Button button3;
        private TextBox idDelete;
        private Label label6;
        private TextBox titleDelete;
        private Label label11;
        private DataGridView deletesearchdatagrid;
        private DataGridViewButtonColumn MovieID;
        private DataGridViewTextBoxColumn MovieName;
        private DataGridViewTextBoxColumn MovieType;
        private DataGridViewTextBoxColumn fee;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn MovieRating;
        private RadioButton idradio;
        private RadioButton titleradio;
        private ComboBox genreBox;
    }
}