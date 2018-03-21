using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        private IProduct _Product;


        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }


        public Product(IProduct iProduct)
        {
            _Product = iProduct;
        }



        public double GetProductPrice(string productName)
        {
            double price = _Product.GetProductPriceFromDB(productName);
            return price;
        }

        public double GetProductPriceFromDB(string productName)
        {
            return Price;
        }
    }
}
