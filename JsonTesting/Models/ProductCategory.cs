using System.Collections.Generic;

namespace JsonTesting.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IList<Product> Products { get; set; }
    }

}