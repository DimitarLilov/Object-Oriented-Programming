﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Interfaces
{
    interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
