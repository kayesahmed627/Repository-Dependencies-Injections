using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Models
{
    public class Product : BaseProductEntity
    {
        public Product()
        {
        }

        public Product(int id,string name, decimal price, int stock, int category) : base(id)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.CategoryId = category;
        }

        public string Name {  get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
