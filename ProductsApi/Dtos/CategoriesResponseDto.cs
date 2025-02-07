namespace ProductsApi.Dtos
{
    /// <summary>
    /// Modelo de dados (DTO) para retornar uma consulta de categorias no serviços da API
    /// </summary>
    public class CategoriesResponseDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }

    }
}
