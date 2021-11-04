using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductInventorySnaphot> ProductInventorySnaphots { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders{ get; set; }
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }


    }
}
