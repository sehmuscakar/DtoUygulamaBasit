namespace DtoProjeTemel.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Cinsiyet { get; set; }
        public string Phone { get; set; }

        public IList<Product> Products { get; set; }

    }
}
