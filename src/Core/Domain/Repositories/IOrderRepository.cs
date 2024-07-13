using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IOrderRepository
    {
        Order GetById(int id);
        Order GetByTimeStamp(DateTime? from, DateTime? to);
        IEnumerable<Order> GetAll();
    }
}
