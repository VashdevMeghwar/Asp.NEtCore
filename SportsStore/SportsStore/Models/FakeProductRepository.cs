using System.Collections;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product
        };
    }
}
