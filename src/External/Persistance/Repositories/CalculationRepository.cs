using Domain.Entities.Calculations;
using Domain.Helpers;
using Domain.Repositories;
using Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class CalculationRepository : ICalculationRepository
    {
        public IEnumerable<AbstractCalculation> GetAll()
        {
            throw new NotImplementedException();
        }

        public AbstractCalculation GetByName(string name)
        {
            return CalculationsFactory.GetCalculatorByName(name);
        }

        public Result<T> Calculate<T>(AbstractCalculation calculation)
        {
            return calculation.Calculate<T>();
        }
    }
}
