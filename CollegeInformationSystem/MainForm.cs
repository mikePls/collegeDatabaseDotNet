using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    internal partial class MainForm : Form
    {
        StudentRecordCard studentRecord;
        QueryHelper queryHelper;
        ResultsForm resultsCard;
        public MainForm()
        {
            ValidateUserLogin();

            InitializeComponent();

            //initialise student record card object:
            studentRecord = StudentRecordCard.GetInstance;
            this.mainPanel.Controls.Add(studentRecord);
            studentRecord.Visible = false;
            studentRecord.Dock = DockStyle.Fill;

            queryHelper = QueryHelper.GetInstance;

            //initialise search results object
            resultsCard = ResultsForm.GetInstance;
            this.mainPanel.Controls.Add(resultsCard);
            resultsCard.Visible = false;
            resultsCard.Dock = DockStyle.Fill;

            LoadFilters();
            
        }

        private void ValidateUserLogin()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void addStudentBtn_click(object sender, EventArgs e)
        {
            resultsCard.Visible = false;
            studentRecord.Visible = true;
            studentRecord.InsertMode();  
        }
        
        /// <summary>
        /// Populates Department and Course-type controlls
        /// </summary>
        private void LoadFilters()
        {
            campusBox.Items.Add("All campuses");
            queryHelper.FindSingleColumn("department_name", "department").ForEach(c => campusBox.Items.Add(c));
            typeBox.Items.Add("All types");
            typeBox.Items.Add("BA");
            typeBox.Items.Add("MD");
            typeBox.Items.Add("PHD");
        }
        public void searchCourses()
        {
            studentRecord.Visible = false;
            List<string> args = new List<string>();
            if (campusBox.SelectedIndex > 0)
            {
                args.Add($"department_name = '{campusBox.Text}'");
            }
            if (typeBox.SelectedIndex > 0)
            {
                args.Add($"course_type = '{typeBox.Text}'");
            }
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < args.Count; i++)
            {
                if (i == 0)
                {
                    sb.Append(" WHERE " + args[i]);
                }
                else
                {
                    sb.Append($" AND {args[i]}");
                }

            }
            resultsCard.View("available_courses", sb.ToString());
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                if (studentRecord.LoadRecord(searchBox.Text))
                {
                    studentRecord.Visible = true;
                }
                else
                    studentRecord.Visible = false;

            }
            else
            {
                MessageBox.Show("Please enter student id first.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void studentOverviewBtn_click(object sender, EventArgs e)
        {
            if (studentRecord.Visible)
            {
                studentRecord.Visible = false;
            }
            resultsCard.View("student", null);
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            searchCourses();
        }

        private void progressBtn_Click(object sender, EventArgs e)
        {
            studentRecord.Visible = false;
            string studentID = progressStudentID.Text;
            string? param = null;
            if (!string.IsNullOrWhiteSpace(studentID))
            {
                param  = $" WHERE student_id = {studentID}";
            }
            resultsCard.View("student_progress", param);
            
        }

        private void campusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCourses();
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCourses();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }
    }
}
