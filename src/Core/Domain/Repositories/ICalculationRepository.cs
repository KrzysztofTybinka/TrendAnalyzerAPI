using Domain.Entities.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICalculationRepository
    {
        Task<AbstractCalculation> GetByNameAsync(string name);
        Task<IEnumerable<AbstractCalculation>> GetAllAsync();
    }
}
