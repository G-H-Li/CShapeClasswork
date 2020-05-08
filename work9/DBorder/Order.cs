using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBorder
{
    public class Order
    {
        [Key,Column(Order=1)]
        public int OrderId { get; set; }
        [Required]
        public string Time { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public int ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        //外键
        public int OrderId { get; set; }
        //多对一关联
        public Order Order { get; set; }
    }
}
