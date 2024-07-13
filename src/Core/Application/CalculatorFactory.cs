using Domain.Entities.Calculators;
using Domain.Exceptions;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CalculatorFactory(IOrderRepository? orderRepository)
    {
        private readonly IOrderRepository? _orderRepository = orderRepository;

        public AbstractCalculator GetCalculatorByName(string name)
        {
            if (name == "Revenue")
                return new RevenueCalculator(_orderRepository);
            else
                throw new CalculationNotFoundException(name);
        }
    }
}
