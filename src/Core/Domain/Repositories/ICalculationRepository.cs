using Domain.Entities.Calculations;
using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICalculationRepository
    {
        AbstractCalculation GetByName(string name);
        IEnumerable<AbstractCalculation> GetAll();
        Result<T> CalculateOne<T>(AbstractCalculation calculation);
    }
}
