﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsAPI.Context;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(ProductsAPIContext))]
    partial class ProductsAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductsAPI.Domains.Product", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(40)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("DECIMAL(10, 2)");

                    b.HasKey("IdProduct");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
