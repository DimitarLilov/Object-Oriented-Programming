﻿using Bank.Interfaces;
namespace Bank
{
    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}