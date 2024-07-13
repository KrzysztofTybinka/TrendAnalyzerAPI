using Domain.Entities.Calculators;
using Domain.Exceptions;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public sealed class CalculatorService
    {
        private readonly ICalculatorRepository _calculatorRepository;

        public CalculatorService(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        public IEnumerable<AbstractCalculator> GetAll()
        {
            throw new NotImplementedException();
        }

        public AbstractCalculator GetByname(string name)
        {
            var calculation = _calculatorRepository.GetByName(name);

            if (calculation == null)
            {
                throw new CalculationNotFoundException(name);
            }

            return calculation;
        }
    }
}
