namespace CMPT291_GROUP_PROJECT
{
    partial class CheckOutPage
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
            this.CopyID = new System.Windows.Forms.Label();
            this.DateTo = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout Info:";
            // 
            // CopyID
            // 
            this.CopyID.AutoSize = true;
            this.CopyID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CopyID.Location = new System.Drawing.Point(194, 138);
            this.CopyID.Name = "CopyID";
            this.CopyID.Size = new System.Drawing.Size(0, 17);
            this.CopyID.TabIndex = 1;
            // 
            // DateTo
            // 
            this.DateTo.AutoSize = true;
            this.DateTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateTo.Location = new System.Drawing.Point(194, 194);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(0, 17);
            this.DateTo.TabIndex = 1;
            // 
            // DateFrom
            // 
            this.DateFrom.AutoSize = true;
            this.DateFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateFrom.Location = new System.Drawing.Point(194, 174);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(0, 17);
            this.DateFrom.TabIndex = 1;
            this.DateFrom.Click += new System.EventHandler(this.label4_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerID.Location = new System.Drawing.Point(194, 212);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(0, 17);
            this.CustomerID.TabIndex = 2;
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.ConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConfirmOrder.FlatAppearance.BorderSize = 3;
            this.ConfirmOrder.Location = new System.Drawing.Point(371, 299);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(153, 40);
            this.ConfirmOrder.TabIndex = 3;
            this.ConfirmOrder.Text = "Confirm Order";
            this.ConfirmOrder.UseVisualStyleBackColor = false;
            this.ConfirmOrder.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(194, 155);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 17);
            this.title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Copy ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(65, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(65, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(65, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date From:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(65, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Customer ID:";
            // 
            // CheckOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 385);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.CopyID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOutPage";
            this.Text = "CheckOutPage";
            this.Load += new System.EventHandler(this.CheckOutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label CopyID;
        private Label DateTo;
        private Label DateFrom;
        private Label CustomerID;
        private Button ConfirmOrder;
        private Label title;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}