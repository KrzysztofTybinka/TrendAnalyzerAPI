using Domain.Entities.Calculations;
using Domain.Exceptions;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public sealed class CalculationService
    {
        private readonly ICalculationRepository _calculationRepository;

        public CalculationService(ICalculationRepository calculationRepository)
        {
            _calculationRepository = calculationRepository;
        }

        public Task<IEnumerable<AbstractCalculation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AbstractCalculation> GetBynameAsync(string name)
        {
            var calculation = await _calculationRepository.GetByNameAsync(name);

            if (calculation == null)
            {
                throw new CalculationNotFoundException();
            }

            return calculation;
        }
    }
}
