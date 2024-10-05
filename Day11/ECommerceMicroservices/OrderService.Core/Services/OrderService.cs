using OrderService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Core.Services
{
    public class OrderService
    {
        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Order placed with {order.Items.Count} items. ");
        }
    }
}
