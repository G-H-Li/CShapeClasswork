using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager order = new OrderManager();
            int orderid = 0;
            orderid = order.AddOrder("lisa", "huawei");
            order.AddItem("phone", 5000, 2, orderid);
            order.AddItem("watch", 1999, 4, orderid);
            orderid = order.AddOrder("Mark", "OPPO");
            order.AddItem("Robot", 3000, 1, orderid);
            order.AddItem("watch", 200, 5, orderid);

            order.SearchOrderById(orderid);

            order.ModifyOrder(orderid, "Sarah", "OPPO");
            order.SearchOrderById(orderid);
            order.ModifyItem(orderid, "Robot", -1, 3);
            order.SearchOrderById(orderid);

            order.DeleteItem(orderid, "watch");
            order.SearchOrderById(orderid);
            order.DeleteOrder(orderid);
            Console.ReadLine();
        }
    }
}
