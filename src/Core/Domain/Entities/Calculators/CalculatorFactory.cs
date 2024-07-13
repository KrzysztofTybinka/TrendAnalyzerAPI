using Domain.Entities.Calculators;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculators
{
    public static class CalculatorFactory
    {
        public static AbstractCalculator GetCalculatorByName(string name)
        {
            if (name == "Revenue")
                return new RevenueCalculator();
            else
                throw new CalculationNotFoundException(name);
        }
    }
}

