using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculations
{
    public static class CalculationsFactory
    {
        public static AbstractCalculation GetCalculatorByName(string name)
        {
            if (name == "Revenue")
                return new RevenueCalculator();
            else
                throw new CalculationNotFoundException();
        }
    }
}
