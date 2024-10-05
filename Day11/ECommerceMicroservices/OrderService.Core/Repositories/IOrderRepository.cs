using OrderService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Core.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        void AddOrder(Order order);
    }
}
