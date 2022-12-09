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
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.ConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConfirmOrder.FlatAppearance.BorderSize = 3;
            this.ConfirmOrder.Location = new System.Drawing.Point(438, 289);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(153, 40);
            this.ConfirmOrder.TabIndex = 3;
            this.ConfirmOrder.Text = "Continue";
            this.ConfirmOrder.UseVisualStyleBackColor = false;
            this.ConfirmOrder.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Come to the store to Confirm Your Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckOutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 385);
            this.Controls.Add(this.ConfirmOrder);
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
        private Button ConfirmOrder;
        private Label label1;
    }
}