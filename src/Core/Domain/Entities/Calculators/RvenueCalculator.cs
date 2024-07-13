using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculators
{
    public class RevenueCalculator : AbstractCalculator
    {
        public override string Name => "Revenue";

        public override string Details => "Details...";

        protected override Result Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
