namespace CMPT291_GROUP_PROJECT
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeRadio = new System.Windows.Forms.RadioButton();
            this.customerRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(260, 232);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(276, 27);
            this.Username.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(260, 287);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(276, 27);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(298, 353);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(200, 41);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(246, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "Log In Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // employeeRadio
            // 
            this.employeeRadio.AutoSize = true;
            this.employeeRadio.Location = new System.Drawing.Point(629, 231);
            this.employeeRadio.Name = "employeeRadio";
            this.employeeRadio.Size = new System.Drawing.Size(96, 24);
            this.employeeRadio.TabIndex = 6;
            this.employeeRadio.TabStop = true;
            this.employeeRadio.Text = "Employee";
            this.employeeRadio.UseVisualStyleBackColor = true;
            // 
            // customerRadio
            // 
            this.customerRadio.AutoSize = true;
            this.customerRadio.Location = new System.Drawing.Point(629, 287);
            this.customerRadio.Name = "customerRadio";
            this.customerRadio.Size = new System.Drawing.Size(93, 24);
            this.customerRadio.TabIndex = 6;
            this.customerRadio.TabStop = true;
            this.customerRadio.Text = "Customer";
            this.customerRadio.UseVisualStyleBackColor = true;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerRadio);
            this.Controls.Add(this.employeeRadio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPage";
            this.Text = "LogInPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button LogInButton;
        private Label label3;
        private PictureBox pictureBox1;
        private RadioButton employeeRadio;
        private RadioButton customerRadio;
    }
}