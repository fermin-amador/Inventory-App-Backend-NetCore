﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PrimaryAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryAddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Data.Models.CustomerAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTaxable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Data.Models.ProductInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdealQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventories");
                });

            modelBuilder.Entity("Data.Models.ProductInventorySnaphot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int");

                    b.Property<DateTime>("SnapshotTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventorySnaphots");
                });

            modelBuilder.Entity("Data.Models.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("Data.Models.SalesOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SalesOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderItems");
                });

            modelBuilder.Entity("Data.Models.Customer", b =>
                {
                    b.HasOne("Data.Models.CustomerAddresses", "PrimaryAddress")
                        .WithMany()
                        .HasForeignKey("PrimaryAddressId");

                    b.Navigation("PrimaryAddress");
                });

            modelBuilder.Entity("Data.Models.ProductInventory", b =>
                {
                    b.HasOne("Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Data.Models.ProductInventorySnaphot", b =>
                {
                    b.HasOne("Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Data.Models.SalesOrder", b =>
                {
                    b.HasOne("Data.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Data.Models.SalesOrderItem", b =>
                {
                    b.HasOne("Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Data.Models.SalesOrder", null)
                        .WithMany("SalesOrderItems")
                        .HasForeignKey("SalesOrderId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Data.Models.SalesOrder", b =>
                {
                    b.Navigation("SalesOrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
