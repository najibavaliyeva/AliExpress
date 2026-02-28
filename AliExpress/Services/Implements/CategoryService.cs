using AliExpress.DTOs.Category;
using AliExpress.Exceptions.NotFoundException;
using AliExpress.Models;
using AliExpress.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Services.Implements
{
    public class CategoryService : IGenericService<CategoryCreateDto>
    {
        private List<Category> _categories = new List<Category>();
        public void Create(CategoryCreateDto dto)
        { var category = new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                CatalogId = dto.CatalogId
            };
            _categories.Add(category);

        }

        public void Delete(int id)
        {
            var Category = _categories.FirstOrDefault(ca => ca.Id == id);
            if (Category == null) throw new CategoryNotFoundException();
                          _categories.Remove(Category);
            
        }       

        public void GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}, CatalogId: {category.CatalogId}");
            }
        }

        public void GetById(int id)
        {
           var category = _categories.FirstOrDefault(ca => ca.Id == id);
            if (category == null) throw new CategoryNotFoundException();
            Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}, CatalogId: {category.CatalogId}");
        }
    }
}
