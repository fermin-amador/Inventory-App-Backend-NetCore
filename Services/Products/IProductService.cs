using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Services.Products
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductbyId(int id);
        ServiceResponse<Product> CreateProduct(Product product);
        ServiceResponse<Product> ArchiveProduct(int id);


    }
}
