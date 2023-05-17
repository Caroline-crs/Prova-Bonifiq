using Microsoft.AspNetCore.Mvc;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services;

namespace ProvaPub.Controllers
{
	
	[ApiController]
	[Route("[controller]")]
	public class Parte2Controller :  ControllerBase
	{
		private readonly TestDbContext _ctx;
		private readonly ProductService _productService;
		private readonly CustomerService _customerService;

        public Parte2Controller(TestDbContext ctx, ProductService productService, CustomerService customerService)
        {
			_ctx = ctx;
			_productService = productService;
			_customerService = customerService;
			
        }

	
		[HttpGet("products")]
		public ProductList ListProducts(int page)
		{ 
			return _productService.ListProducts(page);
		}

		[HttpGet("customers")]
		public CustomerList ListCustomers(int page)
		{
			return _customerService.ListCustomers(page);
		}
	}
}
