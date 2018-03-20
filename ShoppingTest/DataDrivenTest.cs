using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ShoppingTest
{
    /// <summary>
    /// Opis podsumowujący elementu DataDrivenTest
    /// </summary>
    [TestClass]
    public class DataDrivenTest
    {
        public DataDrivenTest()
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
        //        [DeploymentItem("C:\\Users\\pawel\\Documents\\dot net\\Shopping\\Shopping\\dane.xlsx")]
        //        [DataSource("System.Data.OleDb",
        //            "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\pawel\\Documents\\dot net\\Shopping\\Shopping\\dane.xlsx; Persist Security Info=False;",
        //            "Arkusz1$", 
        //            DataAccessMethod.Sequential)]

        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\pawel\Documents\dot net\Shopping\Shopping\dane.xlsx; Extended Properties='Excel 12.0;HDR=yes';",
            "Arkusz1$",
            DataAccessMethod.Sequential
        )]

        //        [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Users\pawel\Documents\dot net\Shopping\Shopping\Database1.mdf;", "Products")]
        public void TestMethod1()
        {
            //double price = Convert.ToDouble((double)testContextInstance.DataRow["Price"]);
            var p = GetTestValueFromColumn("Price");
            var q = GetTestValueFromColumn("Quantity");
            var t = GetTestValueFromColumn("Total");

            Assert.AreEqual(t, p*q, 0.0000001);
        }

        private double GetTestValueFromColumn(string columnName)
        {
            var num = Double.Parse(TestContext.DataRow[columnName].ToString());
            return num;
        }
    }
}
