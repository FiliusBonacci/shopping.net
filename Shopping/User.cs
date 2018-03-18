using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public User(int id, string fn, string ln)
        {
            this.Id = id;
            this.FirstName = fn;
            this.LastName = ln;
        }


        public Checkout buyProduct(Product product)
        {
            Checkout checkout = new Checkout
            {
                User = this,
//                Products = (new List<Product>()).Add(product),
                
            };
            
        
            checkout.Products.Add(product);
            return checkout;

        }

    }
}
