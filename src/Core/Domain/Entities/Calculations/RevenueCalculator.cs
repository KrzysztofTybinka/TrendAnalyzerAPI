using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculations
{
    public class RevenueCalculator : AbstractCalculation
    {
        public override string Name => "Revenue";

        public override string Details { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override Result<T> Calculate<T>()
        {
            throw new NotImplementedException();
        }
    }
}
