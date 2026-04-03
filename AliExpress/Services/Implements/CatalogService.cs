using AliExpress.DTOs.Catalog;
using AliExpress.Exceptions.NotFoundException;
using AliExpress.Models;
using AliExpress.Services.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Services.Implements
{
    public class CatalogService 
    {
        private List<Catalog> _catalogs = new List<Catalog>();
        public Action<CatalogCreateDto> Create;
        public Action<int> Delete;
        public Action GetAll;
        public Action<int> Get;
        public CatalogService()
        {
            
            Create = (dto) =>
            {
                var catalog = new Catalog()
                {
                    Id = dto.Id,
                    Name = dto.Name
                }; _catalogs.Add(catalog);
            };

            Delete = (id) =>
            {
                var catalog = _catalogs.FirstOrDefault(c => c.Id == id);
                if (catalog == null) throw new CatalogNotFoundException();
                _catalogs.Remove(catalog);
            };
            GetAll = () =>
            {

                foreach (var catalog in _catalogs)
                {
                    Console.WriteLine($"Catalog Id: {catalog.Id}, Name: {catalog.Name}");
                }
            };
            Get = (id) =>
            {
                var catalog = _catalogs.FirstOrDefault(c => c.Id == id);
                if (catalog == null) throw new CatalogNotFoundException();
                Console.WriteLine($"Catalog Id: {catalog.Id}, Name: {catalog.Name}");
            };
        }

       
    };
}
