﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bootShop.DataAccess.Data;

namespace bootShop.DataAccess.Migrations
{
    [DbContext(typeof(bootShopDbContext))]
    partial class bootShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bootShop.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Telefon"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Tablet"
                        });
                });

            modelBuilder.Entity("bootShop.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Discount = 0.14999999999999999,
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-product-red-select-2021?wid=940&hei=1112&fmt=png-alpha&.v=1645572315758",
                            IsDeleted = false,
                            Name = "Iphone",
                            Price = 15000.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Discount = 0.25,
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-product-red-select-2021?wid=940&hei=1112&fmt=png-alpha&.v=1645572315758",
                            IsDeleted = false,
                            Name = "Samsung",
                            Price = 9000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Discount = 0.45000000000000001,
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-product-red-select-2021?wid=940&hei=1112&fmt=png-alpha&.v=1645572315758",
                            IsDeleted = false,
                            Name = "Xiaomi",
                            Price = 5000.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Discount = 0.55000000000000004,
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-product-red-select-2021?wid=940&hei=1112&fmt=png-alpha&.v=1645572315758",
                            IsDeleted = false,
                            Name = "Huawei",
                            Price = 6000.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Discount = 0.14999999999999999,
                            ImageUrl = "data:image/jpeg;base64,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",
                            IsDeleted = false,
                            Name = "Asus",
                            Price = 15000.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Discount = 0.25,
                            ImageUrl = "data:image/jpeg;base64,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",
                            IsDeleted = false,
                            Name = "Samsung",
                            Price = 9000.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Discount = 0.45000000000000001,
                            ImageUrl = "data:image/jpeg;base64,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",
                            IsDeleted = false,
                            Name = "Dell",
                            Price = 5000.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Discount = 0.55000000000000004,
                            ImageUrl = "data:image/jpeg;base64,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",
                            IsDeleted = false,
                            Name = "Lenovo",
                            Price = 6000.0
                        });
                });

            modelBuilder.Entity("bootShop.Entities.Product", b =>
                {
                    b.HasOne("bootShop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("bootShop.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
