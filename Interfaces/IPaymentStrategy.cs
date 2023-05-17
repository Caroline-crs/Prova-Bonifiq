using ProvaPub.Models;

namespace ProvaPub.Interfaces
{
    public interface IPaymentStrategy
    {
        Task<Order> Pay(decimal paymentValue, int customerId);
    }
}
