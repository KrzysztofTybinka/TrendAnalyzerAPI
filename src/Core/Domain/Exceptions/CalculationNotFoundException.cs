using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class CalculationNotFoundException : NotFoundException
    {
        public CalculationNotFoundException(string name)
            : base($"There is no calculation named: {name}.")
        {
            
        }
    }
}
