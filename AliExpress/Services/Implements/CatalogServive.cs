using AliExpress.DTOs.Catalog;
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
    public class CatalogServive : IGenericService<CatalogCreateDto>
    {
        private List<Catalog> _catalogs = new List<Catalog>();
        public void Create(CatalogCreateDto dto)
        {
            var catalog = new Catalog
            {
                Id = dto.Id,
                Name = dto.Name

            };
            _catalogs.Add(catalog);
        }
        public void Delete(int id)
        {
            var catalog = _catalogs.FirstOrDefault(c => c.Id == id);
            if (catalog != null) throw new CatalogNotFoundException();
            {
                _catalogs.Remove(catalog);
            }

        }
        public void GetById(int id)
        {
            var catalog = _catalogs.FirstOrDefault(c => c.Id == id);
            if (catalog == null) throw new CatalogNotFoundException();
            Console.WriteLine($"Catalog Id: {catalog.Id}, Name: {catalog.Name}");
        }
        public void GetAll()
        {
            foreach (var catalog in _catalogs)
            {
                Console.WriteLine($"Catalog Id: {catalog.Id}, Name: {catalog.Name}");
            }
        }
    }
}