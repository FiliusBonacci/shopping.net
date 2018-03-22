using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Checkout
    {
        public User User { get; set; }  
        //public List<Product> Products { get; set; }
        public List<Product> Products = new List<Product>();

        public DateTime CreatedAt { get; set; }

        public double getTotal()
        {
            double sum = 0;
            foreach (Product Product in Products)
            {
                sum += (Product.Price * Product.Quantity);
            }
            return sum;
        }

        public string listOfProducts()
        {
            string aaa = "";
            foreach (Product product in Products)
            {
                aaa = string.Join(",", product.Name);
            }

            return aaa;
        }

        public List<Product> productsObjects()
        {
            
            return this.Products;
        }
    }
}
