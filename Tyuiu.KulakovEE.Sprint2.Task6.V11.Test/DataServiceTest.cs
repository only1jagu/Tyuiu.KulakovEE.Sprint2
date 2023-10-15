using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint2.Task6.V11.Lib;

namespace Tyuiu.KulakovEE.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 10;
            int n = 30;
            string wait = (31 + "." + 10 + "." + 2023);
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
}
