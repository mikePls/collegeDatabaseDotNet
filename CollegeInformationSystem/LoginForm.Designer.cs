namespace CollegeInformationSystem
{
    partial class LoginForm
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.loginInvalid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameBox.Location = new System.Drawing.Point(103, 68);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.Size = new System.Drawing.Size(262, 39);
            this.UsernameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(103, 129);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(262, 39);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(167, 206);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(121, 38);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "SUBMIT";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // loginInvalid
            // 
            this.loginInvalid.AutoSize = true;
            this.loginInvalid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginInvalid.ForeColor = System.Drawing.Color.Red;
            this.loginInvalid.Location = new System.Drawing.Point(65, 33);
            this.loginInvalid.Name = "loginInvalid";
            this.loginInvalid.Size = new System.Drawing.Size(359, 32);
            this.loginInvalid.TabIndex = 5;
            this.loginInvalid.Text = "Incorrect username or password.";
            this.loginInvalid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(63, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test login Username: John12 Password:1234";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(457, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginInvalid);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label loginInvalid;
        private System.Windows.Forms.Label label1;
    }
}