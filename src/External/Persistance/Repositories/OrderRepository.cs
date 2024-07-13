using Domain.Entities;
using Domain.Repositories;
using Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Order> GetAll()
        {
            var oredrs = _dbContext.Orders.ToList();
            //to-do mapper from EF models to domain entites
            return new List<Order>();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetByTimeStamp(DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }
    }
}
