namespace CMPT291_GROUP_PROJECT
{
    partial class FindMovieEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindMovieEmployee));
            this.nextButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.CheckBox();
            this.actor = new System.Windows.Forms.CheckBox();
            this.genre = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.CheckBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.actorBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.movieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(881, 455);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(82, 22);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next Page";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 46);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Movie";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 98);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1053, 61);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 345);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 20);
            this.button3.TabIndex = 19;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchResult
            // 
            this.searchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieTitle,
            this.CopyID,
            this.movieID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Fee,
            this.Rating});
            this.searchResult.Location = new System.Drawing.Point(73, 455);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersWidth = 51;
            this.searchResult.RowTemplate.Height = 25;
            this.searchResult.Size = new System.Drawing.Size(787, 125);
            this.searchResult.TabIndex = 26;
            this.searchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search Result:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(355, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Select Your Copy";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(480, 299);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(101, 19);
            this.year.TabIndex = 40;
            this.year.Text = "search by year";
            this.year.UseVisualStyleBackColor = true;
            this.year.CheckedChanged += new System.EventHandler(this.year_CheckedChanged);
            // 
            // actor
            // 
            this.actor.AutoSize = true;
            this.actor.Location = new System.Drawing.Point(480, 257);
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(108, 19);
            this.actor.TabIndex = 39;
            this.actor.Text = "search by Actor";
            this.actor.UseVisualStyleBackColor = true;
            this.actor.CheckedChanged += new System.EventHandler(this.actor_CheckedChanged);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(480, 220);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(110, 19);
            this.genre.TabIndex = 38;
            this.genre.Text = "search by Genre";
            this.genre.UseVisualStyleBackColor = true;
            this.genre.CheckedChanged += new System.EventHandler(this.genre_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(480, 180);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 19);
            this.title.TabIndex = 37;
            this.title.Text = "search by Title";
            this.title.UseVisualStyleBackColor = true;
            this.title.CheckedChanged += new System.EventHandler(this.title_CheckedChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.DisplayMember = "1,2,3,4";
            this.genreComboBox.Enabled = false;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Action",
            "Documentary",
            "Drama",
            "Horror",
            "Romance",
            "Thriller"});
            this.genreComboBox.Location = new System.Drawing.Point(160, 214);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(296, 23);
            this.genreComboBox.Sorted = true;
            this.genreComboBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Actor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Title:";
            // 
            // yearBox
            // 
            this.yearBox.Enabled = false;
            this.yearBox.Location = new System.Drawing.Point(160, 295);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(296, 23);
            this.yearBox.TabIndex = 28;
            // 
            // actorBox
            // 
            this.actorBox.Enabled = false;
            this.actorBox.Location = new System.Drawing.Point(160, 253);
            this.actorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actorBox.Name = "actorBox";
            this.actorBox.ReadOnly = true;
            this.actorBox.Size = new System.Drawing.Size(296, 23);
            this.actorBox.TabIndex = 29;
            // 
            // titleBox
            // 
            this.titleBox.Enabled = false;
            this.titleBox.Location = new System.Drawing.Point(160, 176);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(296, 23);
            this.titleBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Date from:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date To:";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(802, 176);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 23);
            this.dateFrom.TabIndex = 42;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(802, 215);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 23);
            this.dateTo.TabIndex = 42;
            // 
            // movieTitle
            // 
            this.movieTitle.HeaderText = "Title";
            this.movieTitle.MinimumWidth = 6;
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.ReadOnly = true;
            this.movieTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "Copy ID";
            this.CopyID.Name = "CopyID";
            this.CopyID.ReadOnly = true;
            // 
            // movieID
            // 
            this.movieID.HeaderText = "movie ID";
            this.movieID.MinimumWidth = 6;
            this.movieID.Name = "movieID";
            this.movieID.ReadOnly = true;
            this.movieID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.movieID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "year";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.MinimumWidth = 6;
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // FindMovieEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.year);
            this.Controls.Add(this.actor);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.title);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.actorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FindMovieEmployee";
            this.Text = "FindMovieEmployee";
            this.Load += new System.EventHandler(this.FindMovieEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextButton;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button6;
        public Button button3;
        private DataGridView searchResult;
        private Label label6;
        private Label label7;
        private CheckBox year;
        private CheckBox actor;
        private CheckBox genre;
        private CheckBox title;
        private ComboBox genreComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        public TextBox yearBox;
        public TextBox actorBox;
        public TextBox titleBox;
        private Label label8;
        private Label label9;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private DataGridViewTextBoxColumn movieTitle;
        private DataGridViewButtonColumn CopyID;
        private DataGridViewTextBoxColumn movieID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Fee;
        private DataGridViewTextBoxColumn Rating;
    }
}