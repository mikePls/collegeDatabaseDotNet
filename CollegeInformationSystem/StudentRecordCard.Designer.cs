namespace CollegeInformationSystem
{
    partial class StudentRecordCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detsBox = new System.Windows.Forms.GroupBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.headLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.gradesBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enrollmentBtn = new System.Windows.Forms.Button();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.enrollLater = new System.Windows.Forms.CheckBox();
            this.errorHelper = new System.Windows.Forms.ErrorProvider(this.components);
            this.detsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHelper)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "DoB";
            // 
            // detsBox
            // 
            this.detsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detsBox.Controls.Add(this.dobBox);
            this.detsBox.Controls.Add(this.headLabel);
            this.detsBox.Controls.Add(this.surnameBox);
            this.detsBox.Controls.Add(this.nameBox);
            this.detsBox.Controls.Add(this.label3);
            this.detsBox.Controls.Add(this.label4);
            this.detsBox.Controls.Add(this.label5);
            this.detsBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detsBox.Location = new System.Drawing.Point(49, 80);
            this.detsBox.Name = "detsBox";
            this.detsBox.Size = new System.Drawing.Size(401, 228);
            this.detsBox.TabIndex = 11;
            this.detsBox.TabStop = false;
            this.detsBox.Text = "Student Information";
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(137, 184);
            this.dobBox.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dobBox.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(195, 31);
            this.dobBox.TabIndex = 3;
            this.dobBox.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // headLabel
            // 
            this.headLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.headLabel.ForeColor = System.Drawing.Color.Gold;
            this.headLabel.Location = new System.Drawing.Point(6, 27);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(313, 58);
            this.headLabel.TabIndex = 13;
            this.headLabel.Text = "Student ID is provided by the system uppon confirmation";
            // 
            // surnameBox
            // 
            this.surnameBox.AccessibleName = "Last name";
            this.surnameBox.Location = new System.Drawing.Point(137, 141);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(239, 31);
            this.surnameBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "First name";
            this.nameBox.Location = new System.Drawing.Point(137, 98);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(239, 31);
            this.nameBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countryBox);
            this.groupBox1.Controls.Add(this.postcodeBox);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.phoneBox);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(478, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 285);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.AccessibleName = "Country";
            this.countryBox.Location = new System.Drawing.Point(122, 234);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(195, 31);
            this.countryBox.TabIndex = 8;
            // 
            // postcodeBox
            // 
            this.postcodeBox.AccessibleName = "Postcode";
            this.postcodeBox.Location = new System.Drawing.Point(122, 184);
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.Size = new System.Drawing.Size(121, 31);
            this.postcodeBox.TabIndex = 7;
            // 
            // addressBox
            // 
            this.addressBox.AccessibleName = "Address";
            this.addressBox.Location = new System.Drawing.Point(122, 136);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(256, 31);
            this.addressBox.TabIndex = 6;
            // 
            // phoneBox
            // 
            this.phoneBox.AccessibleName = "Phone number";
            this.phoneBox.Location = new System.Drawing.Point(179, 90);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(199, 31);
            this.phoneBox.TabIndex = 5;
            // 
            // emailBox
            // 
            this.emailBox.AccessibleName = "Email";
            this.emailBox.Location = new System.Drawing.Point(110, 42);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(268, 31);
            this.emailBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Postcode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(684, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "College information system v1.0";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submitButton.Location = new System.Drawing.Point(266, 46);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 34);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.submitButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(478, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 115);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(148, 46);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 34);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.Enabled = false;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(30, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 34);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // gradesBtn
            // 
            this.gradesBtn.Enabled = false;
            this.gradesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradesBtn.Location = new System.Drawing.Point(15, 145);
            this.gradesBtn.Name = "gradesBtn";
            this.gradesBtn.Size = new System.Drawing.Size(183, 34);
            this.gradesBtn.TabIndex = 17;
            this.gradesBtn.Text = "View Grades";
            this.gradesBtn.UseVisualStyleBackColor = true;
            this.gradesBtn.Click += new System.EventHandler(this.gradesBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.enrollmentBtn);
            this.groupBox3.Controls.Add(this.gradesBtn);
            this.groupBox3.Controls.Add(this.courseBox);
            this.groupBox3.Controls.Add(this.departmentBox);
            this.groupBox3.Controls.Add(this.enrollLater);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(49, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 195);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enrollment";
            // 
            // enrollmentBtn
            // 
            this.enrollmentBtn.Enabled = false;
            this.enrollmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enrollmentBtn.Location = new System.Drawing.Point(204, 145);
            this.enrollmentBtn.Name = "enrollmentBtn";
            this.enrollmentBtn.Size = new System.Drawing.Size(172, 34);
            this.enrollmentBtn.TabIndex = 17;
            this.enrollmentBtn.Text = "View enrollment";
            this.enrollmentBtn.UseVisualStyleBackColor = true;
            this.enrollmentBtn.Click += new System.EventHandler(this.enrollmentBtn_Click);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(15, 96);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(182, 33);
            this.courseBox.TabIndex = 2;
            this.courseBox.Text = "Course";
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(15, 45);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(272, 33);
            this.departmentBox.TabIndex = 1;
            this.departmentBox.Text = "Department";
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentBox_SelectedIndexChanged);
            // 
            // enrollLater
            // 
            this.enrollLater.AutoSize = true;
            this.enrollLater.Location = new System.Drawing.Point(258, 100);
            this.enrollLater.Name = "enrollLater";
            this.enrollLater.Size = new System.Drawing.Size(121, 29);
            this.enrollLater.TabIndex = 9;
            this.enrollLater.Text = "Enroll later";
            this.enrollLater.UseVisualStyleBackColor = true;
            this.enrollLater.CheckedChanged += new System.EventHandler(this.EnrollLater_CheckedChanged);
            // 
            // errorHelper
            // 
            this.errorHelper.ContainerControl = this;
            // 
            // StudentRecordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detsBox);
            this.Name = "StudentRecordCard";
            this.Size = new System.Drawing.Size(908, 691);
            this.detsBox.ResumeLayout(false);
            this.detsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHelper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox detsBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox postcodeBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.CheckBox enrollLater;
        private System.Windows.Forms.ErrorProvider errorHelper;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button gradesBtn;
        private System.Windows.Forms.Button enrollmentBtn;
        private System.Windows.Forms.DateTimePicker dobBox;
    }
}
