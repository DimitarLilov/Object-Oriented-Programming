using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Person
    {
        private string email;
        private string name;
        private int age;

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Please enter a valid age!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new ArithmeticException("Invalid email!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Age = {1}, Email = {2}", this.Name, this.Age, this.Email ?? "No email");
        }

    }
}
