namespace ProductsApi.Entities
{
    /// <summary>
    /// Classe de entidade para produto
    /// </summary>
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantiity { get; set; }
        public Guid CategoryId { get; set; }

        #region Relacionamento
        public Category? Category { get; set; }

        #endregion


    }
}
