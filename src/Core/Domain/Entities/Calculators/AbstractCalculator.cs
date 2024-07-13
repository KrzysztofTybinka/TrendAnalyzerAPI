using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculators
{
    public abstract class AbstractCalculator
    {
        public abstract string Name { get; }
        public abstract string Details { get; }
        public abstract Result Calculate();
    }
}
