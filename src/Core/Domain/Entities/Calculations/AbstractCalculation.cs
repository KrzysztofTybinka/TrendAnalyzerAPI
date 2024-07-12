using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Domain.Entities.Calculations
{
    public abstract class AbstractCalculation
    {
        public abstract string Name { get; }
        public abstract string Details { get; set; }
        public abstract Result<T> Calculate<T>();
    }
}
