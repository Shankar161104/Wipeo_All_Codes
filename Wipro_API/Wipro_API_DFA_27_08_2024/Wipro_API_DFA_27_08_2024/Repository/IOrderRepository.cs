using Wipro_API_DFA_27_08_2024.Models;


namespace Wipro_API_DFA_27_08_2024.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order SearchOrder(int OrderID);
        Order CreateOrder(Order order);
        Order UpdateOrder(Order order);
        bool DeleteOrder(int OrderID);
    }
}
