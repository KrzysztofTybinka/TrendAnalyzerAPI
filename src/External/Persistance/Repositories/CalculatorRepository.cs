using Domain.Entities.Calculators;
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
    public class CalculatorRepository : ICalculatorRepository
    {
        public IEnumerable<AbstractCalculator> GetAll()
        {
            throw new NotImplementedException();
        }

        public AbstractCalculator GetByName(string name)
        {
            return CalculatorFactory.GetCalculatorByName(name);
        }
    }
}
