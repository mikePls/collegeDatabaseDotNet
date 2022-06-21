namespace CollegeInformationSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressStudentID = new System.Windows.Forms.TextBox();
            this.progressBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.campusBox = new System.Windows.Forms.ComboBox();
            this.coursesBtn = new System.Windows.Forms.Button();
            this.studentOverviewBtn = new System.Windows.Forms.Button();
            this.newStudentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.studentOverviewBtn);
            this.panel1.Controls.Add(this.newStudentBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 644);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressStudentID);
            this.groupBox3.Controls.Add(this.progressBtn);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 127);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student progress";
            // 
            // progressStudentID
            // 
            this.progressStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.progressStudentID.Location = new System.Drawing.Point(6, 82);
            this.progressStudentID.Name = "progressStudentID";
            this.progressStudentID.PlaceholderText = "Student id (optional)";
            this.progressStudentID.Size = new System.Drawing.Size(200, 31);
            this.progressStudentID.TabIndex = 7;
            // 
            // progressBtn
            // 
            this.progressBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBtn.Image = global::CollegeInformationSystem.Properties.Resources.book_open;
            this.progressBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressBtn.Location = new System.Drawing.Point(6, 30);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(200, 46);
            this.progressBtn.TabIndex = 6;
            this.progressBtn.Text = "Student progress";
            this.progressBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.progressBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.progressBtn.UseVisualStyleBackColor = true;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.typeBox);
            this.groupBox2.Controls.Add(this.campusBox);
            this.groupBox2.Controls.Add(this.coursesBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 162);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(6, 121);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(200, 29);
            this.typeBox.TabIndex = 6;
            this.typeBox.Text = "Course type (optional)";
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // campusBox
            // 
            this.campusBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campusBox.FormattingEnabled = true;
            this.campusBox.Location = new System.Drawing.Point(6, 82);
            this.campusBox.Name = "campusBox";
            this.campusBox.Size = new System.Drawing.Size(200, 29);
            this.campusBox.TabIndex = 5;
            this.campusBox.Text = "Department (optional)";
            this.campusBox.SelectedIndexChanged += new System.EventHandler(this.campusBox_SelectedIndexChanged);
            // 
            // coursesBtn
            // 
            this.coursesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coursesBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.coursesBtn.Image = global::CollegeInformationSystem.Properties.Resources.grid;
            this.coursesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursesBtn.Location = new System.Drawing.Point(6, 30);
            this.coursesBtn.Name = "coursesBtn";
            this.coursesBtn.Size = new System.Drawing.Size(200, 46);
            this.coursesBtn.TabIndex = 4;
            this.coursesBtn.Text = "Courses overview";
            this.coursesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coursesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.coursesBtn.UseVisualStyleBackColor = true;
            this.coursesBtn.Click += new System.EventHandler(this.coursesBtn_Click);
            // 
            // studentOverviewBtn
            // 
            this.studentOverviewBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentOverviewBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.studentOverviewBtn.Image = global::CollegeInformationSystem.Properties.Resources.user_silhouette;
            this.studentOverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentOverviewBtn.Location = new System.Drawing.Point(12, 12);
            this.studentOverviewBtn.Name = "studentOverviewBtn";
            this.studentOverviewBtn.Size = new System.Drawing.Size(212, 46);
            this.studentOverviewBtn.TabIndex = 3;
            this.studentOverviewBtn.Text = "Student overview";
            this.studentOverviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentOverviewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.studentOverviewBtn.UseVisualStyleBackColor = true;
            this.studentOverviewBtn.Click += new System.EventHandler(this.studentOverviewBtn_click);
            // 
            // newStudentBtn
            // 
            this.newStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newStudentBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newStudentBtn.Image = global::CollegeInformationSystem.Properties.Resources.plus;
            this.newStudentBtn.Location = new System.Drawing.Point(11, 607);
            this.newStudentBtn.Name = "newStudentBtn";
            this.newStudentBtn.Size = new System.Drawing.Size(212, 34);
            this.newStudentBtn.TabIndex = 2;
            this.newStudentBtn.Text = "Add new Student";
            this.newStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newStudentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newStudentBtn.UseVisualStyleBackColor = true;
            this.newStudentBtn.Click += new System.EventHandler(this.addStudentBtn_click);
            this.newStudentBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addStudentBtn_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student-record search";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(6, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Student id";
            this.searchBox.Size = new System.Drawing.Size(200, 31);
            this.searchBox.TabIndex = 3;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(6, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 38);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(239, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1039, 644);
            this.mainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(543, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designed and implemented by Michail Panagopoulos - 2022";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.studentRecordCard1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Student Information System v1.0";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newStudentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button studentOverviewBtn;
        private System.Windows.Forms.Button coursesBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox campusBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button progressBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox progressStudentID;
        private System.Windows.Forms.Label label1;
        private StudentRecordCard studentRecordCard1;
    }
}
