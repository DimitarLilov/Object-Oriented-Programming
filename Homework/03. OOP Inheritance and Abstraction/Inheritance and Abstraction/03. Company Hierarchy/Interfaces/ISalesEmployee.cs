﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}