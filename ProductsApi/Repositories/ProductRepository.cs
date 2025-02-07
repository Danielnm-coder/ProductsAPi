using ProductsApi.Contexts;
using ProductsApi.Entities;

namespace ProductsApi.Repositories
{
    public class ProductRepository
    {
        public void Add(Product product)
        {
            using(var datacontext = new DataContext())
            {
                datacontext.Add(product);
                datacontext.SaveChanges();
            }

        }

        public void Update(Product product)
        {
            using (var datacontext = new DataContext())
            {
                datacontext.Update(product);
                datacontext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (var datacontext = new DataContext())
            {
                datacontext.Remove(product);
                datacontext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
           using(var datacontext = new DataContext())
            {
                return datacontext
                    .Set<Product>()
                    .ToList();
            }
        }

        public Product? GetById(Guid id)
        {
            using(var datacontext = new DataContext())
            {
                return datacontext
                    .Set<Product>()
                    .Find(id);
            }
        }
    }
}
