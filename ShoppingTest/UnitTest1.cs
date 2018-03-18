using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;

namespace ShoppingTest
{
    [TestClass]
    public class UnitTest1
    {
        private Product p1 = new Product("spodnie", 49.99, 10);
        private Product p2 = new Product("koszula", 29.99, 20);
        private Product p3 = new Product("krawat", 19.99, 10);


        private User u1 = new User(1, "Jan", "Kowalski");
        [TestMethod]
        public void buyProductTest()
        {
            Checkout ch = u1.buyProduct(p1);
            Assert.IsTrue(ch.Products.Contains(p1));

        }

        [TestMethod]
        public void checkoutTotalTest()
        {
            Checkout ch = u1.buyProduct(p1);

            double expected = 499.9;
            Assert.AreEqual(expected, ch.getTotal(), 0.00000001);
        }
    }
}
