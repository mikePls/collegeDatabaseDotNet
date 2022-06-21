using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    internal partial class StudentRecordCard : UserControl
    {
        private QueryHelper queryHelper;
        private Control[] inputControls;
        private Student? student;
        private List<Course>? availableCourses;
        private ResultsForm results = ResultsForm.GetInstance;
        private static StudentRecordCard? instance = null;
        private StudentRecordCard()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            inputControls = new Control[]//Holds references of input controls for fast access
            {
                nameBox, surnameBox, dobBox,
                emailBox, phoneBox, addressBox, countryBox, postcodeBox
            };

            queryHelper = QueryHelper.GetInstance;
            results = ResultsForm.GetInstance;
            LoadCourses();
        }

        //Sends new student values as a query to the SqlHelper object, 
        //to forward to the database
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            switch(submitButton.Text)
            {
                case "Submit":
                    SaveRecord();
                    break;
                case "Save":
                    UpdateRecord();
                    break;
            }
        }

        private void LoadCourses()
        {
            List<String> departments = queryHelper.FindSingleColumn("department_name", "department");
            availableCourses = queryHelper.FindCourses();
            foreach (String department in departments)
            {
                departmentBox.Items.Add(department);
            }
        }

        //departmentBox button handler; Changes content of coursesBox
        //to reflect selected department

        private void DepartmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseBox.Items.Clear();
            string departmentName = departmentBox.SelectedItem.ToString();

            try
            {
                string query = $"Select title from [CollegeDB].[dbo].[Course] WHERE" +
                    $" Course.department_code IN " +
                    $"(SELECT department_id FROM[CollegeDB].[dbo].[Department] WHERE" +
                    $" department_name = '{departmentName}')";

                List<String> courses = queryHelper.Find(query);
                courses.ForEach(department => courseBox.Items.Add(department));
                courseBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected database error:" + ex.Message);
            }

        }

        //Determines if the server shall expect enrollment information
        private void EnrollLater_CheckedChanged(object sender, EventArgs e)
        {
            if (enrollLater.Checked)
            {
                departmentBox.Enabled = false;
                courseBox.Enabled = false;
            }
            else
            {
                departmentBox.Enabled = true;
                courseBox.Enabled = true;
            }
        }

        //Returns true if all mandatory forms have been assigned values
        //by the user, otherwise returns false
        private bool ValidateInput()
        {
            bool isValid = true;
            //check input text is not null
            foreach (Control control in inputControls)
            {
                errorHelper.SetError(control, String.Empty);
                if (control.Text.Length == 0)
                {
                    errorHelper.SetError(control, control.AccessibleName + " cannot be empty.");
                    isValid = false;
                }
            }

            //check enrollment info is provided correctly
            if(!enrollLater.Checked && courseBox.SelectedIndex == -1)
            {
                errorHelper.SetError(enrollLater, "Please choose course or select 'Enroll later");
                isValid=false;
            }
            else errorHelper.SetError(enrollLater, String.Empty);
         
            //check email is proper format
            if(!emailBox.Text.Contains('@') || !emailBox.Text.Contains("."))
            {
                errorHelper.SetError(emailBox, "Not a valid email format.");
                isValid=false;
            }
            else errorHelper.SetError(emailBox, String.Empty);

            //check that phone number contains digits only
            foreach (char c in phoneBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    errorHelper.SetError(phoneBox, "Phone number can only contain digits.");
                    isValid = false;
                    break;
                }
                else errorHelper.SetError(phoneBox, String.Empty);
            }
            return isValid;
        }

        //Enables the class to retrieve a record from the database
        public void LoadMode()
        {
            foreach(Control control in inputControls)
            {
                control.Enabled = false;
                control.Text = "";

            }
            headLabel.Text = "Student ID is provided by the system uppon confirmation";
            submitButton.Text = "Save";
            enrollLater.Checked = true;
            enrollLater.Enabled = true;
            deleteButton.Enabled = false;
            editButton.Enabled = true;
            errorHelper.Clear();
        }

        //Enables the class to create a new student record for the database
        public void InsertMode()
        {
            student = null;
            foreach (Control control in inputControls)
            {
                control.Enabled = true;
                control.Text = "";
            }
            headLabel.Text = "Student ID is provided by the system uppon confirmation";
            submitButton.Text = "Submit";
            enrollLater.Enabled= true;
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            enrollmentBtn.Enabled = false;
            gradesBtn.Enabled = false;
            dobBox.Value = dobBox.MaxDate;
        }

        /// <summary>
        /// takes a string id and loads a record of the corresponding student from the database
        ///returns false if id does not exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool LoadRecord(string id)
        {
            LoadMode();
            this.Visible = true;
            if (!string.IsNullOrWhiteSpace(id))
            {
                student = queryHelper.FindStudent(id);
            }

            if (student != null)
            {

                LoadMode();
                ResultsForm.GetInstance.Visible = false;
                //turnary operator on following string: is student enrolled? then string = "enrolled"
                //else "not enrolled"
                string status = student.IsEnrolled ? "enrolled" : "not enrolled";
                headLabel.Text = $"Student ID: {student.ID}\nStatus: {status}";

                nameBox.Text = student.Name;
                surnameBox.Text = student.LastName;
                dobBox.Value = DateTime.Parse(student.DoB);
                addressBox.Text = student.Address;
                countryBox.Text = student.Country;
                postcodeBox.Text = student.PostCode;
                emailBox.Text = student.Email;
                phoneBox.Text = student.Phone;
                deleteButton.Enabled = true;
                if (student.IsEnrolled)
                {
                    gradesBtn.Enabled = true;
                    enrollmentBtn.Enabled = true;
                    enrollLater.Checked = true;
                    enrollLater.Enabled = false;
                }

                return true;
            }
            else
            {
                MessageBox.Show($"There is no student record with id: {id}", "No results");
                this.Visible = false;
                return false;
            }
            
        }
       
        /// <summary>
        /// Saves the current student record to the database
        /// </summary>
        private void SaveRecord()
        {
            if (ValidateInput() && submitButton.Text == "Submit")
            {
                bool registrationSuccesful;
                string query = "INSERT INTO dbo.student (first_name, last_name, date_of_birth, Address, Country, PostCode, email, phone)" +
                $"VALUES('{nameBox.Text}', '{surnameBox.Text}', '{dobBox.Value.Date.ToString("dd/MM/yyyy")}', '{addressBox.Text}', '{countryBox.Text}', '{postcodeBox.Text}'," +
                $" '{emailBox.Text}', '{phoneBox.Text}')";

                registrationSuccesful = queryHelper.Insert(query);
                if (registrationSuccesful && enrollLater.Checked)
                {
                    MessageBox.Show("Student details have been saved successfully.", "Record updated",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    student = queryHelper.FindStudent(nameBox.Text, surnameBox.Text, postcodeBox.Text);
                    LoadMode();
                    LoadRecord(student.ID);

                }
                else if (registrationSuccesful && !enrollLater.Checked)
                {
                    student = queryHelper.FindStudent(nameBox.Text, surnameBox.Text, postcodeBox.Text);
                    Enroll();
                }
            }
        }

        /// <summary>
        /// Saves student-record changes to the database.
        /// </summary>
        private void UpdateRecord()
        {
            //retrieve student attributes from form controlls
            student.Name = nameBox.Text;
            student.LastName = surnameBox.Text;
            student.Address = addressBox.Text;
            student.Country = countryBox.Text;
            student.PostCode = postcodeBox.Text;
            student.Email = emailBox.Text;
            student.DoB = dobBox.Value.Date.ToString("dd/MM/yyyy");

            //if constraints are validated AND changes are accepted by the database
            if (Validate() && queryHelper.UpdateStudentDetails(student))
            {//do:
                MessageBox.Show("Student details have been updated successfully.", "Record updated",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!enrollLater.Checked)
                {
                    Enroll();
                    return;
                }
                LoadMode();
                LoadRecord(student.ID);
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again, and if the error" +
                    "persists, contact the system administrator.", "Critical error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enrolls current student into the selected Course
        /// </summary>
        private void Enroll()
        {
            Course? course = availableCourses?.Find(x => x.Title == courseBox.Text);
            try { 
            bool successfullyEnrolled = queryHelper.EnrollStudent(student.ID, course.ID);
                if (successfullyEnrolled && course != null)
                {
                    student.IsEnrolled = true;
                    queryHelper.UpdateStudentDetails(student);
                    MessageBox.Show($"Student with id: {student.ID}, has successfully enrolled into " +
                        $"'{course.Title}'", "Enrollment Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMode();
                    LoadRecord(student.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SQL Server ERROR '{ex.Message}'", "Server error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes an existing student from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                DialogResult dialogResult = MessageBox.Show($"WARNING! This action" +
                    $" will permanently remove student with id '{student.ID}' from the system." +
                    $"Are you sure you want to proceed?", "Delete record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (student.IsEnrolled)
                    {
                        queryHelper.DeleteRecord(student.ID, "enrollment");
                    }
                    queryHelper.DeleteRecord(student.ID, "student");
                    MessageBox.Show($"Student record '{student.ID}' has been removed from the system");
                    student = null;
                    LoadMode();
                    this.Visible = false;
                }
            }
        }

        private void gradesBtn_Click(object sender, EventArgs e)
        {
            string param = $" WHERE student_id = {student.ID}";
            results.View("student_progress", param);
            this.Visible = false;
        }

        private void enrollmentBtn_Click(object sender, EventArgs e)
        {
            string param = $" WHERE student_id = {student.ID}";
            results.View("enrollment_details", param);

            this.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
           foreach(Control c in inputControls)
            {
                c.Enabled = true;
            }
           enrollLater.Enabled = true;
        }

        public static StudentRecordCard GetInstance
        {
            get 
            { 
            if (instance == null)
            {
                instance = new StudentRecordCard();
            }
            return instance;
            }
        }
    }
}
