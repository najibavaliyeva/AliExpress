

#region Catalog
using AliExpress.DTOs.Catalog;
using AliExpress.DTOs.Category;
using AliExpress.DTOs.Customer;
using AliExpress.DTOs.Product;
using AliExpress.Services.Implements;
using AliExpress.Services.Interfaces;

IGenericService<CatalogCreateDto> catalogService = new CatalogService();
var catalog1 = new CatalogCreateDto { Id = 1, Name = "Electronics" };
var catalog2 = new CatalogCreateDto { Id = 2, Name = "Clothing" };
#endregion



#region Category

IGenericService<CategoryCreateDto> categoryService = new CategoryService();
var category1 = new CategoryCreateDto { Id = 1, Name = "Mobile Phones", CatalogId = 1 };
var category2 = new CategoryCreateDto { Id = 2, Name = "Laptops", CatalogId = 1 };
#endregion



#region Customer
IGenericService<CustomerCreateDto> customerService = new CustomerService();
var customer1 = new CustomerCreateDto
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    Address = "123 Main St",
    Email = "www.gmail.com",
    Password = "123sdg",
};
#endregion

#region Product
IGenericService<ProductCreateDto> productService = new ProductService();
var product1 = new ProductCreateDto
{
    Id = 1,
    Name = "iPhone 13",
    Description = "Latest Apple iPhone with A15 Bionic chip",
    Price = 94,
    DiscountedPercentage = 87,
    ImageUrl = "https://example.com/iphone13.jpg"
};
#endregion