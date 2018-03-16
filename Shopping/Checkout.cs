using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Checkout
    {
        public User User { get; set; }  
        public List<Product> Products { get; set; }



        public float getTotal()
        {
            float sum = 0;
            foreach (Product Product in Products)
            {
                sum += Product.Price;
            }
            return sum;
        }
    }
}
