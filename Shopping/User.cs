using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public void buyProduct(Product product)
        {
            Checkout checkout = new Checkout();
            checkout.User = this;
            checkout.Products.Add(product);

        }

    }
}
