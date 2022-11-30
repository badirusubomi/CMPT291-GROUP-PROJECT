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
            this.button3 = new System.Windows.Forms.Button();
            this.idDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Existing Copies:";
            // 
            // RentButton
            // 
            this.RentButton.ForeColor = System.Drawing.Color.Black;
            this.RentButton.Location = new System.Drawing.Point(757, 467);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(183, 59);
            this.RentButton.TabIndex = 2;
            this.RentButton.Text = "Rent Now!";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idDelete
            // 
            this.idDelete.Location = new System.Drawing.Point(164, 135);
            this.idDelete.Name = "idDelete";
            this.idDelete.Size = new System.Drawing.Size(317, 27);
            this.idDelete.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Movie ID";
            // 
            // titleDelete
            // 
            this.titleDelete.Location = new System.Drawing.Point(164, 85);
            this.titleDelete.Name = "titleDelete";
            this.titleDelete.Size = new System.Drawing.Size(317, 27);
            this.titleDelete.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(25, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(149, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Insert Data Grid here";
            // 
            // PresentCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentCopies";
            this.Text = "PresentCopies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button RentButton;
        private Button button3;
        private TextBox idDelete;
        private Label label6;
        private TextBox titleDelete;
        private Label label11;
        private Label label2;
    }
}