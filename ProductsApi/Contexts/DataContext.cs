using Microsoft.EntityFrameworkCore;
using ProductsApi.Mappings;

namespace ProductsApi.Contexts
{
    /// <summary>
    /// Classe de cpntexto para conexão com banco de dados e para configuração do Entity Framework
    /// </summary>
    public class DataContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProductsAPI;Integrated Security=True;");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
