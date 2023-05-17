using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.Payments
{
    public class PaymentProcessor
    {
        private readonly IPaymentStrategyFactory _strategyFactory;

        public PaymentProcessor(IPaymentStrategyFactory strategyFactory)
        {
            _strategyFactory = strategyFactory;
        }

        public async Task<Order> ProcessPayment(string paymentMethod, decimal paymentValue, int customerId)
        {
            IPaymentStrategy paymentStrategy = _strategyFactory.Create(paymentMethod);

            if (paymentStrategy == null)
            {
                throw new InvalidOperationException("Invalid payment method.");
            }

            return await paymentStrategy.Pay(paymentValue, customerId);
        }
    }
}
