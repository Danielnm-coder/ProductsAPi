using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Dtos;
using ProductsApi.Entities;
using ProductsApi.Repositories;
using System.Net.WebSockets;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastrar um produto na API
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] ProductRequestDto request)
        {

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Quantiity = request.Quantiity,
                CategoryId = request.CategoryId
            };

            var productRepository = new ProductRepository();
            productRepository.Add(product);


            return Ok(new
            {
                Message = "Produto cadastro com sucesso.",
                CreatedAt = DateTime.Now,
                Product = product.Id,
            });
        }

        /// <summary>
        ///Serviço para atualizar um produto na API
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id,[FromBody] ProductRequestDto request)
        {
            var productRepository = new ProductRepository();
            var product = productRepository.GetById(id);

            product.Name = request.Name;
            product.Price = request.Price;
            product.Quantiity = request.Quantiity;
            product.CategoryId = request.CategoryId;

            productRepository.Update(product);

            return Ok(new
            {
                Message = "Produto atualizado com sucesso.",
                UpdatedAt = DateTime.Now,
                ProductID = id,
            });

        }

        /// <summary>
        /// Serviço para deletar um produto na API
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var productRepository = new ProductRepository();
            var product = productRepository.GetById(id);


            productRepository.Delete(product);


            return Ok(new
            {
                Message = "Produto Deletado com sucesso.",
                DeleteAt = DateTime.Now,
                ProductID = id,
            });
        }

        /// <summary>
        /// Serviço para consulta de produtos na API
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {

            var productRepository = new ProductRepository();

            var products = productRepository.GetAll();

            var response = new List<ProductResponseDto>();

            foreach (var product in products)
            {
                response.Add(new ProductResponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantiity = product.Quantiity,
                    CategoryId = product.CategoryId
                });

            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(Guid id)
        {
            var productRepository = new ProductRepository();
            var product = productRepository.GetById(id);

            var response = new ProductResponseDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantiity = product.Quantiity,
                CategoryId = product.CategoryId
            };

            return Ok(response);
        }
    }
}
