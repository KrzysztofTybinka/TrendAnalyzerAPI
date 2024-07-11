﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculations
{
    public abstract class AbstractCalculation
    {
        public abstract string Name { get; set; }
        public abstract string Details { get; set; }
        public abstract Result<T> Calculate<T>();
    }
}
