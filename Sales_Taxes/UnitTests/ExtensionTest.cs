using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Sales_Taxes.UnitTests
{
    [TestClass]
    public class ExtensionTest
    {
        
        [TestMethod]
        public void DoubleRoundToPointZeroZeroFiveTest()
        {
            decimal input = 23.456M;
            decimal output = Helper.RoundToZeroPointFive(input);

            Assert.AreEqual(output, 23.5M);

        }

        [TestMethod]
        public void DoubleRoundToPointZeroZeroFiveTest2()
        {
            decimal input = 23.567M;
            decimal output = Helper.RoundToZeroPointFive(input);
            Assert.AreEqual(output, 23.60M);
        }

        [TestMethod]
        public void CalcTotalPriceTest()
        {
            SalesItem input1 = new SalesItem(ItemTypes.Other, "Item description", 23.650M, false, 1);
            SalesItem input2 = new SalesItem(ItemTypes.Food, "Food item description", 56.770M, false, 1);
            SalesItem input3 = new SalesItem(ItemTypes.Medical, "Imported Medical item", 44.550M, true, 1);
            SalesItem input4 = new SalesItem(ItemTypes.Other, "Imported general items", 134.550M, true, 1);

            decimal totPrice1 = Math.Round(input1.TotalPrice, 2);
            decimal totPrice2 = Math.Round(input2.TotalPrice, 2);
            decimal totPrice3 = Math.Round(input3.TotalPrice, 2);
            decimal totProce4 = Math.Round(input4.TotalPrice, 2);

            Assert.AreEqual(totPrice1, 26.05M);
            Assert.AreEqual(totPrice2, 56.77M);
            Assert.AreEqual(totPrice3, 46.81M);
            Assert.AreEqual(totProce4, 154.75M);
        }
    }
}
