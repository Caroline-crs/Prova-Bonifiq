using ProvaPub.Interfaces;

namespace ProvaPub.Models
{
    public class PaginatedList<T> : IPaginatedList<T>
    {
        public int TotalCount { get; set; }
        public int HasNext { get; set; }
        public List<T> Items { get; set; }

    }
}
