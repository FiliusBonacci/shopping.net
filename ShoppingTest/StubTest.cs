﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Fakes;
using Shopping;
using Shopping.Fakes;

namespace ShoppingTest
{
    /// <summary>
    /// Opis podsumowujący elementu StubTest
    /// </summary>
    [TestClass]
    public class StubTest
    {
        public StubTest()
        {
        }

        private TestContext testContextInstance;

      
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Dodatkowe atrybuty testu
        //
        // Można użyć następujących dodatkowych atrybutów w trakcie pisania testów:
        //
        // Użyj ClassInitialize do uruchomienia kodu przed uruchomieniem pierwszego testu w klasie
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Użyj ClassCleanup do uruchomienia kodu po wykonaniu wszystkich testów w klasie
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Użyj TestInitialize do uruchomienia kodu przed uruchomieniem każdego testu 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Użyj TestCleanup do uruchomienia kodu po wykonaniu każdego testu
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
//            IProduct iProduct = new StubIProduct()
//            {
//                GetProductPriceFromDBString = (productName) => { return 49.99; }
//            };
//            Product product = new Product(iProduct);
//            double result = product.GetProductPrice("koszula");
//            Assert.AreEqual(49.99, result);
        }


        [TestMethod]
        public void ShimsTest()
        {
//            using (ShimsContext.Create())
//            {
//                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2018, 3, 23);
//
//                var checkout = new Checkout();
//
//                var expected = new DateTime(2018, 3, 23);
//                Assert.AreEqual(expected, checkout.CreatedAt);
//            }
        }
    }
}
