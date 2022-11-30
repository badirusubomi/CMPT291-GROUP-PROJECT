namespace CMPT291_GROUP_PROJECT
{
    partial class searchResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectMovie = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Result:";
            // 
            // SelectMovie
            // 
            this.SelectMovie.Location = new System.Drawing.Point(604, 195);
            this.SelectMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectMovie.Name = "SelectMovie";
            this.SelectMovie.Size = new System.Drawing.Size(167, 37);
            this.SelectMovie.TabIndex = 1;
            this.SelectMovie.Text = "Pick Movie";
            this.SelectMovie.UseVisualStyleBackColor = true;
            this.SelectMovie.Click += new System.EventHandler(this.SelectMovie_Click);
            // 
            // searchResult
            // 
            this.searchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ttile,
            this.Genre,
            this.Year,
            this.Fee,
            this.Rating});
            this.searchResult.Location = new System.Drawing.Point(27, 65);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowTemplate.Height = 25;
            this.searchResult.Size = new System.Drawing.Size(744, 125);
            this.searchResult.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "movieID";
            this.ID.Name = "ID";
            // 
            // Ttile
            // 
            this.Ttile.HeaderText = "title";
            this.Ttile.Name = "Ttile";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Year
            // 
            this.Year.HeaderText = "year";
            this.Year.Name = "Year";
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "rating";
            this.Rating.Name = "Rating";
            // 
            // searchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(783, 243);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.SelectMovie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchResultForm";
            this.Text = "searchResultForm";
            this.Load += new System.EventHandler(this.searchResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button SelectMovie;
        private DataGridView searchResult;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn Ttile;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Fee;
        private DataGridViewTextBoxColumn Rating;
    }
}