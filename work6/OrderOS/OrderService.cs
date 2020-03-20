using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderOS
{
    class OrderService
    {
        private List<Order> orders;  //订单集合
        private int id;  //订单id

        public OrderService()
        {
            this.orders = new List<Order>();
            this.id = 0;
        }

        public void AddOrder(string buyer, string seller)
        {
            //添加订单,入参买家、卖家
            this.orders.Add(new Order(this.id, buyer, seller));
            Console.WriteLine("依次输入货品名;单价;数量，不同数据间用一个空格间隔");
            for (int i = 0; i < 3; i++)
            {
                //输入货品名;单价;数量，不同数据间用一个空格空开
                string str = Console.ReadLine();
                string[] item = str.Split(" ");
                string name = item[0];
                float price = (float)Convert.ToDouble(item[1]);
                int quantity = Convert.ToInt32(item[2]);
                this.orders[this.id].AddItem(name, price, quantity);
            }
            this.id += 1;
        }

        public void Disp()
        {
            foreach(Order order in this.orders)
            {
                Console.Write(order.ToString());
            }
        }

        public void DeleteOrder(int id)
        {
            //移除订单号为id的整个订单
            this.orders.RemoveAll(order => order.Id == id);
        }

        public void DeleteOrderItem(int id, int index)
        {
            int modified = 0;
            try
            {
                for (int i = 0; i < this.orders.Count; i++)
                {
                    if (id >= 0 && id == this.orders[i].Id)
                    {
                        this.orders[i].DeleteItem(index);
                        modified = 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }

            if (modified == 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public void DeleteOrderItems(int id, string name, float price, int quan)
        {
            int modified = 0;
            try
            {
                for (int i = 0; i < this.orders.Count; i++)
                {
                    if (id >= 0 && id == this.orders[i].Id)
                    {
                        this.orders[i].DeleteItems(name, price, quan);
                        modified = 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }

            if (modified == 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public List<Object> SearchOrders(int id, string buyer, string seller, string name, float uPrice, int quan)
        {
            //先根据num、buyer、seller找到合适的订单，然后再对合适订单进行明细查找
            List<Object> result = new List<Object>();
            var query1 = from order in this.orders
                         where id >= 0 && order.Id == id
                         select order;
            var query2 = from order in query1
                         where buyer != null && order.BuyerName == buyer
                         select order;
            var query3 = from order in query2
                         where seller != null && order.SellerName == seller
                         orderby order.TotalPrice 
                         select order;
            foreach(Order order in query3)
            {
                result.Add(order);
                foreach(OrderItem item in order.SearchItems(name, uPrice, quan))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<Object> SearchOrders(int id, string name, float uPrice, int quan)
        {
            //查找某个订单里面的明细
            List<Object> result = new List<Object>();
            var query = from order in this.orders
                         where id >= 0 && order.Id == id
                         orderby order.TotalPrice
                         select order;
            foreach (Order order in query)
            {
                result.Add(order);
                foreach (OrderItem item in order.SearchItems(name, uPrice, quan))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public void ModifyOrderHeader(int id, string buyer, string seller)
        {
            int modified = 0;
            for(int i=0;i<this.orders.Count;i++)
            {
                if (this.orders[i].Id == id)
                {
                    if (buyer != null && buyer != "") this.orders[i].BuyerName = buyer;
                    if (seller != null && seller != "") this.orders[i].SellerName = seller;
                    modified = 1;
                }
            }
            
            if (modified == 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void ModifyOrderItem(int id, int index, string name, float price, int quan)
        {
            int modified = 0;
            try
            {
                for (int i = 0; i < this.orders.Count; i++)
                {
                    if (id >= 0 && id == this.orders[i].Id)
                    {
                        this.orders[i].ModifyItem(index, name, price, quan);
                        modified = 1;
                    }
                }
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
            
            if(modified == 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void ModifyOrderItems(int id, string oName, float oPrice, int oQuan, string name, float price, int quan)
        {
            int modified = 0;
            try
            {
                for (int i = 0; i < this.orders.Count; i++)
                {
                    if (id >= 0 && id == this.orders[i].Id)
                    {
                        this.orders[i].ModifyItems(oName, oPrice, oQuan, name, price, quan);
                        modified = 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }

            if (modified == 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
