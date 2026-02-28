using AliExpress.DTOs.Product;
using AliExpress.Exceptions.InvalidException;
using AliExpress.Exceptions.NotFoundException;
using AliExpress.Extensions;
using AliExpress.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Services.Implements
{
    public class  ProductService: IGenericService<ProductCreateDto>
    { private readonly List<ProductCreateDto> _products = new List<ProductCreateDto>();
        public void Create(ProductCreateDto dto)
        {    var result = dto.Price.IsGreaterThanZero();
            if (!result) throw new PriceInvalidException();
            var product = new ProductCreateDto
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                DisCountedPrice = (dto.Price * (100 - dto.DiscountedPercentage)) / 100,
                ImageUrl = dto.ImageUrl
            };
            _products.Add(product);
        }
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) throw new ProductNotFoundException();
            
                _products.Remove(product);
            
        }

        public void GetAll()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Description: {product.Description}, Price: {product.Price}, Discounted Price: {product.DiscountedPercentage}, Image URL: {product.ImageUrl}");
            }
        }

        public void GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) throw new ProductNotFoundException();  
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Description: {product.Description}, Price: {product.Price}, Discounted Price: {product.DiscountedPercentage}, Image URL: {product.ImageUrl}");
            
        }
    }
}
