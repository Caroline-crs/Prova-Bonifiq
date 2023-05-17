using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService 
	{
		private readonly IPaymentStrategy _paymentStrategy;

        public OrderService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }


		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			return await _paymentStrategy.ProcessPayment(paymentMethod, paymentValue, customerId);
		}
	}
}
