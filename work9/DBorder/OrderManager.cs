using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBorder
{
    class OrderManager
    {
        public int AddOrder(string buyer, string seller)
        {
            //add order and return order's id
            using (var context = new OrderContext())
            {
                var order = new Order { Buyer = buyer, Seller = seller, Time = DateTime.Now.ToString() };
                order.Items = new List<Item>();
                context.Orders.Add(order);
                context.SaveChanges();
                SearchOrderById(order.OrderId);
                Console.WriteLine("Add Order finished!");
                return order.OrderId;
            }
        }

        public int AddItem(string name, int price, int quantity, int orderId)
        {
            //add item by orderid and return itemid
            using(var context = new OrderContext())
            {
                var item = new Item() { Name = name, Price = price, Quantity = quantity, OrderId = orderId };
                context.Entry(item).State = EntityState.Added;
                context.SaveChanges();
                SearchItemById(item.ItemId);
                Console.WriteLine("Add item finished!");
                return item.ItemId;
            }
        }

        public void SearchOrderById(int orderId)
        {
            using (var context=new OrderContext())
            {
                var order = context.Orders.SingleOrDefault(b => b.OrderId == orderId);
                if(order != null)
                {
                    int totalPrice = 0;
                    IOrderedQueryable<Item> items = SearchItems(orderId);
                    foreach (var item in items)
                    {
                        totalPrice += (item.Price * item.Quantity);
                    }
                    Console.WriteLine($"订单号：{order.OrderId}，订单时间：{order.Time}，买家：{order.Buyer}，卖家：{order.Seller}，订单总价：{totalPrice}");
                    SearchItemsByOrderId(order.OrderId);
                }
            }
        }

        private IOrderedQueryable<Item> SearchItems(int orderId)
        {
            var context = new OrderContext();
            var query = context.Items.Where(i => i.OrderId == orderId).OrderBy(i => i.Name);
            return query;
        }

        private void SearchItemById(int itemId)
        {
            using (var context = new OrderContext())
            {
                var item = context.Items.SingleOrDefault(i => i.ItemId == itemId);
                if (item != null)
                {
                    Console.WriteLine($" 货物名称：{item.Name}，单价：{item.Price}，数量：{item.Quantity}，总价：{item.Price * item.Quantity}");
                }
            }
        }

        private void SearchItemsByOrderId(int orderId)
        {
            foreach(var item in SearchItems(orderId))
            {
                Console.WriteLine($" 货物名称：{item.Name}，单价：{item.Price}，数量：{item.Quantity}，总价：{item.Price* item.Quantity}");
            }
        }

        public void ModifyItem(int orderId, string itemName, int price, int quantity)
        {
            using(var context = new OrderContext())
            {
                var item = context.Items.FirstOrDefault(i => i.OrderId == orderId && i.Name == itemName);
                if(item != null)
                {
                    if (price >= 0) item.Price = price;
                    if (quantity > 0) item.Quantity = quantity;
                    context.SaveChanges();
                    SearchItemById(item.ItemId);
                    Console.WriteLine("Modify item finished!");
                }
            }
        }

        public void ModifyOrder(int orderId, string buyer, string seller)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    if (buyer != null) order.Buyer = buyer;
                    if (seller != null) order.Seller = seller;
                    context.SaveChanges();
                    SearchOrderById(order.OrderId);
                    Console.WriteLine("Modify order finished!");
                }
            }
        }

        public void DeleteItem(int orderId, string itemName)
        {
            using (var context = new OrderContext())
            {
                var item = context.Items.FirstOrDefault(i => i.OrderId == orderId && i.Name == itemName);
                if (item != null)
                {
                    context.Items.Remove(item);
                    context.SaveChanges();
                    Console.WriteLine("Delete item finished!");
                }
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                    Console.WriteLine("Delete order finished!");
                }
            }
        }
    }
}
