using AliExpress.DTOs.Customer;
using AliExpress.Exceptions.NotFoundException;
using AliExpress.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Services.Implements
{
    public class CustomerService : IGenericService<CustomerCreateDto>
    {
        private List<CustomerCreateDto> _customers = new List<CustomerCreateDto>();
        public void Create(CustomerCreateDto dto)
        {
            var customer = new CustomerCreateDto
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber
            }; _customers.Add(customer);
        }


        public void Delete(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) throw new CustomerNotFoundException();
            
                _customers.Remove(customer);
            
         }

     

        public void GetAll()
        {
            foreach (var customer in _customers)
            {Console.WriteLine($"Id: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");
            }
        }

        public void GetById(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) throw new CustomerNotFoundException();        
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");
            
        }
    }
}
