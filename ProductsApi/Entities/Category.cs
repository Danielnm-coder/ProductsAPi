namespace ProductsApi.Entities
{
    /// <summary>
    /// Classe de entidade para categoria
    /// </summary>
    public class Category
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }



        #region Relacinamento

        public List<Product>? Product { get; set; }

        #endregion

    }
}
