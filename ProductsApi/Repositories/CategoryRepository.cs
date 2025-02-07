using ProductsApi.Contexts;
using ProductsApi.Entities;

namespace ProductsApi.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetCategory()
        {
            using (var datacontext = new DataContext())
            {
                return datacontext
                    .Set<Category>()
                    .OrderBy(c => c.Name)
                    .ToList();
            }
        }

    }
}
