using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderOS
{
    class SameItemOrderException:Exception
    {
        //相同明细异常
        public SameItemOrderException(string message) : base(message) { }
        public override string Message => base.Message;
    }

    class Order:IComparable
    {
        private readonly int id;  //订单号,一次生成不可修改
        private string time;  //订单时间
        private readonly float totalPrice;  //订单总价
        private string buyerName;  //买家名称
        private string sellerName;  //卖家名称
        private List<OrderItem> items;  //消费明细

        public Order(int num, string buyer, string seller)
        {
            if (num < 0 || buyer == null || seller == null)
            {
                throw new FormatException();
            }
            this.id = num;
            this.time = DateTime.Now.ToString();
            this.BuyerName = buyer;
            this.SellerName = seller;
            this.items = new List<OrderItem>();
            this.totalPrice = 0;
        }

        public override bool Equals(object obj)
        {
            Order od = obj as Order;
            return od != null && od.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public string HeaderToString()
        {
            //返回订单头部信息
            return $"订单号：{this.Id}，订单时间：{this.Time}，买家：{this.BuyerName}，卖家：{this.SellerName}，订单总价：{this.TotalPrice}\n";
        }

        public override string ToString()
        {
            //返回整个订单的信息
            string info = this.HeaderToString();
            int i = 0;
            foreach(OrderItem item in this.items)
            {
                info = info+ i +item.ToString();
                i += 1;
            }
            return info;
        }

        public int Id => id;

        public string Time { get => time; set => time = value; }

        public float TotalPrice
        {
            get
            {
                float price = 0;
                foreach(OrderItem item in this.items)
                {
                    price += item.TotalPrice;
                }
                return price;
            }
        }
        
        public string BuyerName { get => buyerName; set => buyerName = value; }
        
        public string SellerName { get => sellerName; set => sellerName = value; }
        
        public void AddItem(string name, float uPrice, int quan)
        {
            //传入 货品名称，单价，数量
            try
            {
                OrderItem obj = new OrderItem(name, uPrice, quan);
                foreach (OrderItem item in this.items)
                {
                    if (item.Equals(obj))
                    {
                        throw new SameItemOrderException(item.ToString());
                    }
                }
                this.items.Add(obj);
            }
            catch(FormatException)
            {
                throw new FormatException();
            }
            
        }

        public void ModifyItems(string oName, float oPrice, int oQuan, string name, float price, int quan)
        {
            //修改所有符合条件的明细
            List<int> indexs = this.SearchItem(oName, oPrice, oQuan);
            foreach (int index in indexs)
            {
                this.ModifyItem(index, name, price, quan);
            }
        }

        public void ModifyItem(int index, string name, float price, int quan)
        {
            //根据索引进行修改明细
            try
            {
                if (name != null && name != "") this.items[index].ItemName = name;
                if (price >= 0) this.items[index].UnitPrice = price;
                if (quan > 0) this.items[index].Quantity = quan;
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void DeleteItems(string name, float price, int quan)
        {
            //删除所有符合条件的明细
            List<int> indexs = this.SearchItem(name, price, quan);
            foreach (int index in indexs)
            {
                this.DeleteItem(index);
            }
        }

        public void DeleteItem(int index)
        {
            //根据索引删除某条明细
            try
            {
                this.items.RemoveAt(index);
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private List<int> SearchItem(string name, float uPrice, int quan)
        {
            //类内部删除、修改明细使用
            List<int> indexs = new List<int>(); 
            for(int i=0; i<this.items.Count; i++)
            {
                if (name != null && name != "" && name == this.items[i].ItemName) indexs.Add(i);
                if (uPrice >= 0 && uPrice == this.items[i].UnitPrice && !indexs.Contains(i)) indexs.Add(i);
                if (quan > 0 && quan == this.items[i].Quantity && !indexs.Contains(i)) indexs.Add(i);
            }
            return indexs;
        }

        public List<OrderItem> SearchItems(string name, float uPrice, int quan)
        {
            //外部查找明细使用
            if (name == "" && uPrice < 0 && quan < 0) return null;
            var query1 = from item in this.items
                         where name != null && item.ItemName == name
                         select item;
            var query2 = from item in query1
                         where uPrice >= 0 && item.UnitPrice == uPrice
                         select item;
            var query3 = from item in query2
                         where quan > 0 && item.Quantity == quan
                         orderby item.TotalPrice
                         select item;
            return query3.ToList();
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Order))
            {
                throw new ArgumentException();
            }
            Order od = (Order)obj;
            return this.Id.CompareTo(od.Id);
        }
    }
}
