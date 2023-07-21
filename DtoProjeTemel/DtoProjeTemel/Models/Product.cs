namespace DtoProjeTemel.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Brand { get; set; }
        public string  Model{ get; set; }

        public int Price { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
