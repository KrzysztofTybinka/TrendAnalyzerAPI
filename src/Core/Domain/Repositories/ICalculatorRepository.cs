using Domain.Entities.Calculators;
using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICalculatorRepository
    {
        AbstractCalculator GetByName(string name);
        IEnumerable<AbstractCalculator> GetAll();
    }
}
