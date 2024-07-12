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

        public IEnumerable<AbstractCalculation> GetAll()
        {
            throw new NotImplementedException();
        }

        public AbstractCalculation GetByname(string name)
        {
            var calculation = _calculationRepository.GetByName(name);

            if (calculation == null)
            {
                throw new CalculationNotFoundException(name);
            }

            return calculation;
        }
    }
}
