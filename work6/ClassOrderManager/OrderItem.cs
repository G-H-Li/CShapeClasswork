using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrderManager
{
    public class OrderItem
    {
        private int id; //id
        private string itemName;  //货物名称
        private float unitPrice;   //货物单价
        private int quantity;  //货物数量
        private float totalPrice;  //货物总价

        public OrderItem() 
        {
            this.Id = 0;
            this.ItemName = "";
            this.UnitPrice = 0;
            this.Quantity = 0;
            this.totalPrice = 0;
        }

        public OrderItem(int id, string name, float uPrice, int quan)
        {
            if (name == null || name == "" || uPrice < 0 || quan <= 0)
            {
                throw new FormatException();
            }
            this.Id = id;
            this.ItemName = name;
            this.UnitPrice = uPrice;
            this.Quantity = quan;
            this.totalPrice = uPrice * quan;
        }

        public override string ToString()
        {
            return $" 货物名称：{this.ItemName}，单价：{this.UnitPrice}，数量：{this.Quantity}，总价：{this.TotalPrice}\n";
        }

        public override bool Equals(Object obj)
        {
            OrderItem item = obj as OrderItem;
            if (item != null && item.ItemName == this.ItemName && item.UnitPrice == this.UnitPrice && item.Quantity == this.Quantity && item.TotalPrice == this.TotalPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (int)this.UnitPrice + this.Quantity * (int)this.TotalPrice;
        }

        public string ItemName { get => itemName; set => itemName = value; }

        public float UnitPrice { get => unitPrice; set => unitPrice = value; }

        public int Quantity { get => quantity; set => quantity = value; }

        public float TotalPrice { get => this.Quantity * this.UnitPrice; }
        public int Id { get => id; set => id = value; }
    }
}
