namespace DtoProjeTemel.Models
{
    public class ProductDto
    {
        public int ıd { get; set; }
        public string title { get; set; }
        public string brand { get; set; }
        public string model { get; set; }

        public int price { get; set; }

        public string Customerad { get; set; }//değiştirildi ad olarak ve string oolarak normalde CustomerID veri türü int idi
        public Customer Customer { get; set; }

    }
}
