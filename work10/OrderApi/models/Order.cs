using System.Collections.Generic;

namespace OrderApi.Models
{
    public class Order
    {
        public int OrderId{get; set;}
        public string Time{get; set;}
        public string Buyer{get; set;}
        public string Seller{get; set;}
        public List<Item> Items{get; set;}
    }
}