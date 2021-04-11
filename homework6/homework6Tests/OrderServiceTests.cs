using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService administrator = new OrderService();
        Order orderForTest = new Order(new Client("张三", "15529993888", "WHU"), "20214130", 0.8, DateTime.Now, new OrderDetails("QQ糖", 5, 6));
        Order orderForTest2 = new Order(new Client("李四", "15529993888", "WHU"), "20214130", 0.8, DateTime.Now, new OrderDetails("QQ糖", 5, 6));
        OrderDetails detailForTest = new OrderDetails("biscuit", 8, 3);
        [TestInitialize]
        public void Init()
        {
            administrator.AddOrder(orderForTest);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest()
        {
            //检查重复
            administrator.AddOrder(new Order(new Client("张三", "15529993888", "WHU"), "20214130", 0.8, DateTime.Now, new OrderDetails("QQ糖", 5, 6)));
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            Assert.AreEqual(true, administrator.DeleteOrder(orderForTest));
        }

        [TestMethod()]
        public void QueryOrderTest()
        {
            Assert.AreEqual(orderForTest, administrator.QueryOrder("20214130"));
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            Assert.AreNotEqual(orderForTest, administrator.ModifyOrder(orderForTest, orderForTest2));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ExportTest()
        {
            administrator.Export("test.txt");
        }

        [TestMethod()]
        public void ImportTest()
        {
            administrator.Export("test.xml");
            administrator.ordersList.Clear();
            administrator.Import("test.xml");
            Assert.AreEqual("20214130", administrator.ordersList.First().OrderId);
        }
        [TestCleanup]
        public void Clean()
        {
            File.Delete("test.xml");
            File.Delete("test.txt");
            File.Create("test.xml");
            File.Create("test.txt");
        }
    }
}