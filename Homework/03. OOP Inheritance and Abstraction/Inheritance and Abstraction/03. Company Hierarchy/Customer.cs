using _03.Company_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    class Customer : Person, ICustomer
    {
        public Customer(string id, string firstName, string lastName
            , decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
        }

        private decimal netPurchaseAmount;

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                Utilities.ValidateNumber(value, "Net purchase amount");
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string info = String.Format("ID: {0}, Name: {1} {2}, Net purchase amount: {3}\n------\n",
                this.ID, this.FirstName, this.LastName, this.NetPurchaseAmount);
            return info;
        }
    }
}
