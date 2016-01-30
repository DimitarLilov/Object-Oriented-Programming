using _03.Company_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    abstract class Person : IPerson
    {
        protected Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private string id;
        private string firstName;
        private string lastName;

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                Utilities.ValidateString(value, "ID");
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Utilities.ValidateString(value, "First name");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Utilities.ValidateString(value, "Last name");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string info = String.Format("ID: {0}, Name: {1} {2}\n------\n",
                this.ID, this.FirstName, this.LastName);
            return info;
        }

    }
}
