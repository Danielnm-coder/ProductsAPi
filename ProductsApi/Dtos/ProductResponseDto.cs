namespace ProductsApi.Dtos
{
    public class ProductResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantiity { get; set; }
        public decimal? Total { get { return Price * Quantiity; } } 
        public Guid CategoryId { get; set; }
    }
}
