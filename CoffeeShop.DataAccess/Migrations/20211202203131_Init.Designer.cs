﻿// <auto-generated />
using System;
using CoffeeShop.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeShop.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211202203131_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeShop.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Coffee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoffeeCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoffeeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeCategoryId");

                    b.ToTable("Coffee");
                });

            modelBuilder.Entity("CoffeeShop.Entity.CoffeeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoffeeCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoffeeCategory");
                });

            modelBuilder.Entity("CoffeeShop.Entity.CoffeePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoffeePlaceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeePlaceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("CoffeePlace");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoffeePlaceId")
                        .HasColumnType("int");

                    b.Property<double>("CoffeePlaceScore")
                        .HasColumnType("float");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserMailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoffeePlaceId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoffeePlaceId")
                        .HasColumnType("int");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoffeePlaceId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("CoffeeShop.Entity.MenuCoffee", b =>
                {
                    b.Property<int>("CoffeeId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("CoffeeId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuCoffee");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Coffee", b =>
                {
                    b.HasOne("CoffeeShop.Entity.CoffeeCategory", "CoffeeCategory")
                        .WithMany("Coffees")
                        .HasForeignKey("CoffeeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeCategory");
                });

            modelBuilder.Entity("CoffeeShop.Entity.CoffeePlace", b =>
                {
                    b.HasOne("CoffeeShop.Entity.Region", "Region")
                        .WithMany("CoffeePlaces")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Comment", b =>
                {
                    b.HasOne("CoffeeShop.Entity.CoffeePlace", "CoffeePlace")
                        .WithMany("UserComments")
                        .HasForeignKey("CoffeePlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeePlace");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Menu", b =>
                {
                    b.HasOne("CoffeeShop.Entity.CoffeePlace", "CoffeePlace")
                        .WithMany("Menus")
                        .HasForeignKey("CoffeePlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeePlace");
                });

            modelBuilder.Entity("CoffeeShop.Entity.MenuCoffee", b =>
                {
                    b.HasOne("CoffeeShop.Entity.Coffee", "Coffee")
                        .WithMany("MenuCoffee")
                        .HasForeignKey("CoffeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoffeeShop.Entity.Menu", "Menu")
                        .WithMany("MenuCoffee")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coffee");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Region", b =>
                {
                    b.HasOne("CoffeeShop.Entity.City", "City")
                        .WithMany("Regions")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CoffeeShop.Entity.City", b =>
                {
                    b.Navigation("Regions");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Coffee", b =>
                {
                    b.Navigation("MenuCoffee");
                });

            modelBuilder.Entity("CoffeeShop.Entity.CoffeeCategory", b =>
                {
                    b.Navigation("Coffees");
                });

            modelBuilder.Entity("CoffeeShop.Entity.CoffeePlace", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("UserComments");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Menu", b =>
                {
                    b.Navigation("MenuCoffee");
                });

            modelBuilder.Entity("CoffeeShop.Entity.Region", b =>
                {
                    b.Navigation("CoffeePlaces");
                });
#pragma warning restore 612, 618
        }
    }
}