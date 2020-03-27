using System;

namespace OrderOS
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            service.AddOrder("Alan", "HuaWei");
            service.AddOrder("Amy", "OPPO");
            service.AddOrder("Tank", "VIVO");

            service.Disp();

            service.Export();
            service.Import("./export.xml");
            //待测试
        }
    }
}
 