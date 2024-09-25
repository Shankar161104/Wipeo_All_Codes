using Microsoft.Identity.Client;
using Wipro_API_DFA_27_08_2024.Models;

namespace Wipro_API_DFA_27_08_2024.Repository
{
    public class OrderRepository : IOrderRepository
    {

        private readonly WiproDfa26082024Context wiproDfa26082024Context;

        public OrderRepository(WiproDfa26082024Context _wiproDfa26082024Context)
        {
            wiproDfa26082024Context = _wiproDfa26082024Context;
        }





        public Order CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            var result = wiproDfa26082024Context.Add(order);
            wiproDfa26082024Context.SaveChanges();
            return result.Entity;
        }

        public bool DeleteOrder(int OrderID)
        {
            var filteredData = wiproDfa26082024Context.Orders.Where(x => x.OrderId == OrderID).FirstOrDefault();
            wiproDfa26082024Context.Orders.Remove(filteredData);
            wiproDfa26082024Context.SaveChanges();
            return filteredData != null ? true : false;

        }

        public IEnumerable<Order> GetAllOrders()
        {
            return wiproDfa26082024Context.Orders.ToList();
        }

        public Order SearchOrder(int OrderID)
        {
            return wiproDfa26082024Context.Orders.Where(x=>x.OrderId == OrderID).FirstOrDefault();
        }

        public Order UpdateOrder(Order order)
        {
            var result = wiproDfa26082024Context.Orders.Update(order);
            wiproDfa26082024Context.SaveChanges();
            return result.Entity;
        }
    }
}
