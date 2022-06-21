using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CollegeInformationSystem
{
    //Class implemented with Singleton pattern, in order to avoid
    //creating multiple connections to the server
    internal sealed class QueryHelper
    {
        private static QueryHelper? instance = null;

        private SqlDataReader dataReader;
        public string connectionDetails;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        private QueryHelper()
        {
            //Server name, Database name, and security parameters stored in
            //connectionDetails variable
            connectionDetails = "Data Source = USERONE; Initial Catalog = " +
                "CollegeDB; Integrated Security = True";
            //connection details passed into a new SQL connection object
            connection = new SqlConnection(connectionDetails);
            try { 
                connection.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Connection Error: {ex.Message}. \n This program" +
                    $"will now terminate.", "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        /// <summary>
        /// Returns the object of this Singleton class
        /// </summary>
        public static QueryHelper GetInstance
        { 
            get { return instance ?? (instance = new QueryHelper()); } 
        }

        /// <summary>
        /// Takes table name and SQL 'WHERE' conditions as strings.
        /// Returns a DataSet object of results from the database.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="filters"></param>
        /// <returns></returns>
        public DataSet FindAll(string table, string? filters) 
        {
            string query= $"SELECT * FROM [CollegeDB].[dbo].[{table}]";
            if(filters != null)
            {
                query = query + " " + filters;
            }
            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(ds, table);
            return ds;
        }

        /// <summary>
        /// Returns a list of the database query that corresponds to
        /// given column and table parameters.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> FindSingleColumn(string columnName, string table)
        {
            List<string> results = new List<string>();
            string query = $"Select {columnName} from [CollegeDB].[dbo].[{table}]";
            

            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    results.Add(item: dataReader.GetValue(0).ToString());
                }
            dataReader.Close();
            return results;
            
        }

        /// <summary>
        /// Takes a query parameter as string and forwards it to
        /// the database. Returns a list of possible results.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<string> Find(string query)
        {
            List<string> results = new List<string>();
            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                results.Add(dataReader.GetValue(0)?.ToString());
            }
            dataReader.Close ();
            return results;
        }

        /// <summary>
        ///Takes a string parameter and returns a Student object that
        /// corresponds to the database record with given id.
        /// Returns null if id is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Student</returns>
        public Student? FindStudent(string id)
        {
            Dictionary<string, string?> results = new Dictionary<string, string?>();
            
            string query = $"Select * from [CollegeDB].[dbo].[Student]" +
                $"WHERE student_id = {id}";

            
            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    results[dataReader.GetName(i)] = dataReader.GetValue(i).ToString();
                }
                dataReader.Close();
                return new Student(results);
            }
            dataReader.Close();
            return null;
        }
        public Student? FindStudent(string name, string lastName, string postCode)
        {
            Dictionary<string, string?> results = new Dictionary<string, string?>();

            string query = $"Select * from [CollegeDB].[dbo].[Student]" +
                $"WHERE first_name = '{name}' AND last_name = '{lastName}' AND postcode = '{postCode}'";


            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            try
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    results[dataReader.GetName(i)] = dataReader.GetValue(i).ToString();
                }
                dataReader.Close();
                return new Student(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL server error" + ex.Message);
                return null;
            }
            
        }
        
        /// <summary>
        /// Sends given query to database. Returns true if successful,
        /// otherwise returns false.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool Insert(string query)
        {
            try
            {
                command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
        //Returns a Course List of all the available courses in 
        //the database
        public List<Course>? FindCourses()
        {
            string query = "Select course_id, title from [CollegeDB].[dbo].[Course]";
            List<Course> courses = new List<Course>();

            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Course newCourse = new Course(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString());

                courses.Add(newCourse); 
            }

            dataReader.Close();
            return courses;
        }
        /// <summary>
        /// Takes student id, and course id as Strings, and attempts to
        /// enroll an existing student in the database.
        /// Returns true on successful enrollment, otherwise returns false.
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public bool EnrollStudent(string studentID, string courseID)
        {
            string query = "INSERT INTO CollegeDB.dbo.enrollment " +
                "(student_id, course_id, enrollment_date)" +
                $" VALUES ('{studentID}', '{courseID}', " +
                $"'{DateTime.Now.ToString("dd/MM/yyyy")}')";
            try
            {
                command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery() == 1;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message + 
                    "\n Please try again. If the error persists, contact" +
                    " your system administrator.", "Server Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRecord(string id, string table)
        {
            try
            {
                string query = $"DELETE FROM [dbo].[{table}] WHERE student_id = {id}";
                command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        ///Returns true if id and password arguments exist in the database
        ///otherwise returns false
        public bool ValidateLogin(string usr, string psr)
        {
            string query = "SELECT * FROM [CollegeDB].[dbo].[user_login] " +
                $"WHERE username = '{usr}' AND password = '{psr}'";
            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            bool hasRows = dataReader.HasRows;
            dataReader.Close();
            return hasRows;
        }

        /// <summary>
        /// Updates a student's information in the database.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool UpdateStudentDetails(Student s)
        {
            try
            {
                string query = $"Update CollegeDB.dbo.student SET " +
                $"first_name = '{s.Name}', last_name = '{s.LastName}'," +
                $"date_of_birth = '{s.DoB}', address = '{s.Address}', country = '{s.Country}'," +
                $"postcode = '{s.PostCode}', email = '{s.Email}', phone = '{s.Phone}'," +
                $" is_enrolled = '{s.IsEnrolled}'" +
                $" WHERE student_id = {s.ID}";

                command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery() == 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }
}
