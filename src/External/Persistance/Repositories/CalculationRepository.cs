using Domain.Entities.Calculations;
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
        private readonly ApplicationDbContext _dbContext;

        public CalculationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<AbstractCalculation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AbstractCalculation> GetByNameAsync(string name)
        {
            var articles = _dbContext.Articles;
            throw new NotImplementedException();
        }
    }
}
