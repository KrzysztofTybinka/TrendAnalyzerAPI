using Domain.Helpers;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Calculators
{
    public class RevenueCalculator : AbstractCalculator
    {
        public override string Name => "Revenue";

        public override string Details => "Details...";

        private IOrderRepository _orderRepository;

        public RevenueCalculator(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public override Result Calculate()
        {
            var orders = _orderRepository.GetAll();
            double income = orders.Sum(x => x.TotalPrice.Value);
            double cost = orders.Sum(x => x.TotalCost
                .Sum(y => y.Value.Value));

            var result = new Result();
            result.Value.Add(income - cost);
            result.Unit = "Money";

            return result;
        }
    }
}
