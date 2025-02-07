using ProductsApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Dtos
{
    /// <summary>
    /// Modelo de dados (DTO) para receber uma solicitação/requiseção de cadastro ou atualizaçõ de produto da API
    /// </summary>
    public class ProductRequestDto
    {
        [MaxLength(100, ErrorMessage = "O campo 'Name' deve ter no máximo {1} caracteres")]
        [MinLength(8,ErrorMessage = "O campo 'Name' deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "O campo 'Name' é obrigatório")]
        public string? Name { get; set; }

        [Range(0.01, 999999999, ErrorMessage = "Por favor, informe o preço entrre {1} e {2}")]
        [Required(ErrorMessage = "O campo 'Price' é obrigatório")]
        public decimal? Price { get; set; }

        [Range(1, 99999, ErrorMessage = "Por favor, informe a quantidade entre {1} e {2}")]
        [Required(ErrorMessage = "O campo 'Quantity' é obrigatório")]
        public int? Quantiity { get; set; }

        [Required(ErrorMessage = "O campo 'CategoryId' é obrigatório")]
        public Guid CategoryId { get; set; }


    }
}
