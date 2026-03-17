namespace Sklad1.Data
{
    internal class Product
    {
        public int id { get; set; }
        public string article { get; set; }
        public string name { get; set; }
        public int category_id { get; set; }
        public decimal purchase_price { get; set; }
        public int quantity { get; set; }
    }
}
