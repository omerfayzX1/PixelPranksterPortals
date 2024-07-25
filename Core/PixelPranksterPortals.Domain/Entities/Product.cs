using PixelPranksterPortals.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPranksterPortals.Domain.Entities
{
    public class Product:EntityBase
    {
        public Product()
        {
        }

        public Product(int price, int discount, int stock, string description)
        {
            Price = price;
            Discount = discount;
            Stock = stock;
            Description = description;
        }

        public int Price { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }


        public ICollection<Category> Categories { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
