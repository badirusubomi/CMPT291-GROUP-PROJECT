namespace CMPT291_GROUP_PROJECT
{
    partial class PresentCopies
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
            this.RentButton = new System.Windows.Forms.Button();
            this.CopyTable = new System.Windows.Forms.DataGridView();
            this.CopyID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CopyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Existing Copies:";
            // 
            // RentButton
            // 
            this.RentButton.ForeColor = System.Drawing.Color.Black;
            this.RentButton.Location = new System.Drawing.Point(662, 350);
            this.RentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(160, 44);
            this.RentButton.TabIndex = 2;
            this.RentButton.Text = "Rent Now!";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // CopyTable
            // 
            this.CopyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CopyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CopyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyID,
            this.Title,
            this.Format});
            this.CopyTable.Location = new System.Drawing.Point(22, 94);
            this.CopyTable.Name = "CopyTable";
            this.CopyTable.RowTemplate.Height = 25;
            this.CopyTable.Size = new System.Drawing.Size(800, 237);
            this.CopyTable.TabIndex = 3;
            this.CopyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CopyTable_CellContentClick);
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "Copy ID";
            this.CopyID.Name = "CopyID";
            this.CopyID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.ReadOnly = true;
            this.Format.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Format.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PresentCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(858, 410);
            this.Controls.Add(this.CopyTable);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PresentCopies";
            this.Text = "PresentCopies";
            this.Load += new System.EventHandler(this.PresentCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CopyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button RentButton;
        private DataGridView CopyTable;
        private DataGridViewButtonColumn CopyID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Format;
    }
}