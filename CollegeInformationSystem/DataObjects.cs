using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    internal class DataObjects
    {
    }
    class Student
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? DoB { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? Country { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsEnrolled { get; set; }



        //Enrollment attributes:
        string CourseID { get; set; }
        string CourseTitle { get; set; }

        public Student(Dictionary<string, string?> input)
        {
            ID = input["student_id"];
            Name = input["first_name"];
            LastName = input["last_name"];
            DoB = input["date_of_birth"];
            Address = input["address"];
            PostCode = input["postcode"];
            Country = input["country"];
            Email = input["email"];
            Phone = input["phone"];
            IsEnrolled = input["is_enrolled"] == "True";

        }
        public Student()
        {

        }
    }
    class Course
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public Course(string i,string t)
        {
            ID=i;
            Title = t;
        }
    }
}
