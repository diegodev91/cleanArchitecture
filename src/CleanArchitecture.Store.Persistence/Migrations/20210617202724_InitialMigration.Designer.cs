﻿// <auto-generated />
using System;
using CleanArchitecture.Store.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArchitecture.Store.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210617202724_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CleanArchitecture.Store.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("EndOfContract")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "AdminUserID",
                            CreatedDate = new DateTime(2021, 6, 17, 15, 27, 23, 698, DateTimeKind.Local).AddTicks(1970),
                            EndOfContract = new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "VideoGames",
                            Provider = "Amazon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "AdminUserID",
                            CreatedDate = new DateTime(2021, 6, 17, 15, 27, 23, 714, DateTimeKind.Local).AddTicks(8510),
                            EndOfContract = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TV",
                            Provider = "Local"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "AdminUserID",
                            CreatedDate = new DateTime(2021, 6, 17, 15, 27, 23, 714, DateTimeKind.Local).AddTicks(8640),
                            EndOfContract = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Computers",
                            Provider = "Local"
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Store.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Play Station 5",
                            Price = 3500.00m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "X Box",
                            Price = 2500.00m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Nintendo Switch",
                            Price = 2200.00m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Samsumg TV 65'",
                            Price = 5600.00m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "LG OLED TV 75'",
                            Price = 15000.00m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Panasonic",
                            Price = 1500.00m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "MacBook Pro 13'",
                            Price = 10000.00m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Alienware 15'",
                            Price = 5700.00m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Currency = "S/.",
                            Name = "Asus Pro 2tb 15'",
                            Price = 2200.00m,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("CleanArchitecture.Store.Domain.Entities.Product", b =>
                {
                    b.HasOne("CleanArchitecture.Store.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CleanArchitecture.Store.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
