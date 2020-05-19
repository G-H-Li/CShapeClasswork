namespace OrderApi.Models
{
    public class Item
    {
        public int ItemId{get; set;}
        public string Name{get; set;}
        public int Price{get; set;}
        public int Quantity{get; set;}
        public int OrderId{get; set;}
        public Order Order{get; set;}
    }
}