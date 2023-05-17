using ProvaPub.Interfaces;

namespace ProvaPub.Models
{
	public class ProductList : IPaginatedList<Product>
	{
		public List<Product> Products { get; set; }
		public int TotalCount { get; set; }
		public bool HasNext { get; set; }
	}
}
