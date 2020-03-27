using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderOS.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService service;

        [TestInitialize]
        public void TestInit()
        {
            this.service = new OrderService();
        }

        [TestCleanup]
        public void PrintInfo()
        {
            this.service.Disp();
        }

        [TestMethod]
        public void OrderServiceTest()
        {
            Assert.IsNotNull(this.service.orders);
            Assert.AreEqual(this.service.id, 0);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            string[] buyer = { "Alan", "Amy", "Tank" };
            string[] seller = { "HuaWei", "VIVO", "OPPO" };
            for(int i=0; i<buyer.Length; i++)
            {
                this.service.AddOrder(buyer[i], seller[i]);
            }
            Assert.AreEqual(this.service.id, buyer.Length);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("删除订单");
            this.service.DeleteOrder(2);
            Assert.AreEqual(this.service.orders.Count, 2);
        }

        [TestMethod()]
        public void DeleteOrderItemTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("删除具体订单中具体项目");
            this.service.DeleteOrderItem(2, 0);
        }

        [TestMethod()]
        public void DeleteOrderItemsTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("删除具体订单中多个项目");
            this.service.DeleteOrderItems(1, "耳机", 0, 0);
        }

        [TestMethod()]
        public void SearchOrdersTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("查询：");
            this.service.SearchOrders(1, "耳机", 0, 0).ForEach(order => Console.Write(order));
            Console.WriteLine("查询结束");
        }

        [TestMethod()]
        public void SearchOrdersTest1()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("查询：");
            this.service.SearchOrders("Alan", "", "耳机", 0, 0).ForEach(order => Console.Write(order));
            Console.WriteLine("查询结束");
        }

        [TestMethod()]
        public void ModifyOrderHeaderTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("修改订单头");
            this.service.ModifyOrderHeader(1, "Mark", "Seller");
        }

        [TestMethod()]
        public void ModifyOrderItemTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("修改具体订单当中的具体条目");
            this.service.ModifyOrderItem(0, 1, "手机", 1800, 100);
        }

        [TestMethod()]
        public void ModifyOrderItemsTest()
        {
            this.AddOrderTest();
            this.PrintInfo();
            Console.WriteLine("修改一个订单当中的多个条目");
            this.service.ModifyOrderItems(2, "耳机",0, 0, "手机", 0, 0);
        }
    }
}