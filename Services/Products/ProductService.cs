using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Products
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<Product> ArchiveProduct(int id)
        {
            
            try
            {
                var product = _db.Products.Find(id);
                product.IsArchived = true;
                _db.SaveChanges();
                return new ServiceResponse<Product>
                {
                    Data = product,
                    IsSuccess = true,
                    Message = "Archived Product",
                    Time = DateTime.UtcNow
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Product>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow
                };
            }
        }

        public ServiceResponse<Product> CreateProduct(Product product)
        {
            try
            {
                _db.Products.Add(product);

                var newInventory = new ProductInventory
                {
                    Product = product,
                    QuantityOnHand = 0,
                    IdealQuantity = 10
                };
                _db.ProductInventories.Add(newInventory);

                _db.SaveChanges();

                return new ServiceResponse<Product>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = "Saved new Product",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Product>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = e.Message,
                    IsSuccess = false
                };

            }
           
        }

        public List<Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public Product GetProductbyId(int id)
        {
            return _db.Products.Find(id);
        }
    }
}
