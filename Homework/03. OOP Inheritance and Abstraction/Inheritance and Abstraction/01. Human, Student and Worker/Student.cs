using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number cannot be null or empty");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw new ArgumentException("Faculty number must contain 5-10 digits / letters");
                }
                this.facultyNumber = value;
            }
        }
    }
}
