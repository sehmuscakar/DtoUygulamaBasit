using Microsoft.EntityFrameworkCore;

namespace DtoProjeTemel.Models
{
    public class Context:DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

       
        public IList<ProductDto> GetCustomerList()
        {
            
            using (var context = new Context())
            {
                var a = context.Products.Select(product => new ProductDto()

                {
                  ıd=product.ID,
                  title=product.Title,
                  brand=product.Brand,
                  model=product.Model,
                  price=product.Price,
                    Customerad = product.Customer.Name,

                });
                return a.ToList();
            }

          
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=DTOProje; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
