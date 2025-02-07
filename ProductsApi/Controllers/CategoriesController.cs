using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Dtos;
using ProductsApi.Repositories;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        /// <summary>
        /// Serviço para consulta de categorias da APi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var categoryRepository = new CategoryRepository();

            var categories = categoryRepository.GetCategory();

            var response = new List<CategoriesResponseDto>();

            foreach (var category in categories)
            {
                response.Add(new CategoriesResponseDto
                {
                    Id = category.Id,
                    Name = category.Name
                });
            }

            return Ok (response);
        }
    }
}
