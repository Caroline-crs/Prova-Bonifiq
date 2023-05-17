using ProvaPub.Interfaces;

namespace ProvaPub.Payments
{
    public class PaymentStrategyFactory : IPaymentStrategyFactory
    {
        public PaymentStrategyFactory Create(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "px":
                    return new PixPaymentStrategy();

                case "creditcard":
                    return new CreditCardPaymentStrategy();

                case "paypal":
                    return new PaypalPaymentStrategy();

                default:
                    return null;
            }
        }
    }
}
