namespace ProvaPub.Services
{
	public class RandomService
	{
		 
		int seed = DateTime.Now.Millisecond;
		public RandomService()
		{
			seed = Guid.NewGuid().GetHashCode();
		}
		public int GetRandom()
		{
			return new Random(seed).Next(100);
		}

	}
}
