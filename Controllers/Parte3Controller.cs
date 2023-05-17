using Microsoft.AspNetCore.Mvc;
using ProvaPub.Interfaces;
using ProvaPub.Models;
using ProvaPub.Payments;
using ProvaPub.Services;

namespace ProvaPub.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class Parte3Controller :  ControllerBase
	{
		private readonly OrderService _orderService;

		public Parte3Controller(OrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet("orders")]
		public async Task<Order> PlaceOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			IPaymentStrategy paymentStrategy;

			if (paymentMethod == "pix")
				paymentStrategy = new PixPaymentStrategy();

			else if (paymentMethod == "creditcard")
				paymentStrategy = new CreditCardPaymentStrategy();

			else if (paymentMethod == "paypal")
				paymentStrategy = new PaypalPaymentStrategy();

			else
				throw new Exception("Invalid payment method");

			return await paymentStrategy.Pay(paymentValue, customerId);
		}
	}
}
