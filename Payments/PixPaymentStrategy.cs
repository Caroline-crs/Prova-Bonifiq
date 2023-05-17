using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.Payments
{
    public class PixPaymentStrategy : IPaymentStrategy
    {
        public async Task<Order> Pay(decimal paymentValue, int customerId)
        {
            //colocar método de pagamento

            return await Task.FromResult(new Order
            {
                Value = paymentValue,
                CustomerId = customerId
            });
        }
    }
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public async Task<Order> Pay(decimal paymentValue, int customerId)
        {
            //colocar método de pagamento

            return await Task.FromResult(new Order()
            {
                Value = paymentValue
            });
        }

    }
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        //colocar método de pagamento

        public async Task<Order> Pay(decimal paymentValue, int customerId)
        {
            return await Task.FromResult(new Order()
            {
                Value = paymentValue
            });
        }
    }
}
