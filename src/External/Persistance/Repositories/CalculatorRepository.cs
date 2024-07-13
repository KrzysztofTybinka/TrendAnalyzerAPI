using Application;
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
        private readonly IOrderRepository _orderRepository;

        public CalculatorRepository(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<AbstractCalculator> GetAll()
        {
            throw new NotImplementedException();
        }

        public AbstractCalculator GetByName(string name)
        {
            var factory = new CalculatorFactory(_orderRepository);
            return factory.GetCalculatorByName(name);
        }
    }
}
