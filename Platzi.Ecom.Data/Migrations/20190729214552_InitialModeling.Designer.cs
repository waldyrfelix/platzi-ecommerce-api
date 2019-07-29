﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Platzi.Ecom.Data.EF;

namespace Platzi.Ecom.Data.Migrations
{
    [DbContext(typeof(PlatziDbContext))]
    [Migration("20190729214552_InitialModeling")]
    partial class InitialModeling
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Platzi.Ecom.Core.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("DeliveryAddress");

                    b.Property<int>("OrderStatus");

                    b.Property<decimal>("TotalValue");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductReferenceId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductReferenceId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Products.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Photo");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Orders.Order", b =>
                {
                    b.HasOne("Platzi.Ecom.Core.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Orders.OrderItem", b =>
                {
                    b.HasOne("Platzi.Ecom.Core.Orders.Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("Platzi.Ecom.Core.Products.Product", "ProductReference")
                        .WithMany()
                        .HasForeignKey("ProductReferenceId");
                });

            modelBuilder.Entity("Platzi.Ecom.Core.Products.Product", b =>
                {
                    b.HasOne("Platzi.Ecom.Core.Products.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
