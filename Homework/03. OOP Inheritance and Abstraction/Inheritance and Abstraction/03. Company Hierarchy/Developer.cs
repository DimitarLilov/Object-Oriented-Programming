using _03.Company_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string id, string firstName, string lastName
            , decimal salary, Department department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        private List<Project> projects;

        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                Utilities.ValidateList(value, "Projects");
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string info = String.Format("ID: {0}, Name: {1} {2}, Net purchase amount: {3}\n------\n",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department, this.Projects);
            return info;
        }
    }
}
