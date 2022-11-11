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
            this.OrderID = new System.Windows.Forms.Label();
            this.DateTo = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout Info:";
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderID.Location = new System.Drawing.Point(23, 73);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(76, 20);
            this.OrderID.TabIndex = 1;
            this.OrderID.Text = "Order ID:";
            // 
            // DateTo
            // 
            this.DateTo.AutoSize = true;
            this.DateTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateTo.Location = new System.Drawing.Point(23, 113);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(68, 20);
            this.DateTo.TabIndex = 1;
            this.DateTo.Text = "Date To:";
            // 
            // DateFrom
            // 
            this.DateFrom.AutoSize = true;
            this.DateFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateFrom.Location = new System.Drawing.Point(23, 93);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(88, 20);
            this.DateFrom.TabIndex = 1;
            this.DateFrom.Text = "Date From:";
            this.DateFrom.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeID.Location = new System.Drawing.Point(23, 133);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(105, 20);
            this.EmployeeID.TabIndex = 1;
            this.EmployeeID.Text = "Employee ID:";
            this.EmployeeID.Click += new System.EventHandler(this.label4_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerID.Location = new System.Drawing.Point(23, 153);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(103, 20);
            this.CustomerID.TabIndex = 2;
            this.CustomerID.Text = "Customer ID:";
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.ConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConfirmOrder.FlatAppearance.BorderSize = 3;
            this.ConfirmOrder.Location = new System.Drawing.Point(172, 186);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(153, 40);
            this.ConfirmOrder.TabIndex = 3;
            this.ConfirmOrder.Text = "Confirm Order";
            this.ConfirmOrder.UseVisualStyleBackColor = false;
            this.ConfirmOrder.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // CheckOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 277);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.OrderID);
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
        private Label OrderID;
        private Label DateTo;
        private Label DateFrom;
        private Label EmployeeID;
        private Label CustomerID;
        private Button ConfirmOrder;
    }
}