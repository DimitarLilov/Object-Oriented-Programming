using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The week salary cannot be a negative number");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 && value > 44)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day must be in the range [0;24]");
                
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal MoneyPerHour()
        {
            decimal moneyPerDay = this.weekSalary / 7;
            decimal moneyPerHour = moneyPerDay / this.workHoursPerDay;
            return moneyPerHour;
        }
    }
}
