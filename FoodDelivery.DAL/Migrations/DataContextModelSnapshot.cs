﻿// <auto-generated />
using System;
using FoodDelivery.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDelivery.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Baskets", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("Amount")
                        .HasColumnType("smallint");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(5,3)");

                    b.HasKey("Id");

                    b.ToTable("Dishes", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<string>("Commentary")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DateCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CustomerRating")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VendorId");

                    b.ToTable("Reviews", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClosingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CustomerRaiting")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OpeningTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("TimeOfDelivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Vendors", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Basket", b =>
                {
                    b.HasOne("FoodDelivery.DAL.Entity.User", "User")
                        .WithOne("Basket")
                        .HasForeignKey("FoodDelivery.DAL.Entity.Basket", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Order", b =>
                {
                    b.HasOne("FoodDelivery.DAL.Entity.Basket", "Basket")
                        .WithMany("Orders")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Profile", b =>
                {
                    b.HasOne("FoodDelivery.DAL.Entity.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("FoodDelivery.DAL.Entity.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Review", b =>
                {
                    b.HasOne("FoodDelivery.DAL.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.DAL.Entity.Vendor", "Vendor")
                        .WithMany("Reviews")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Vendor", b =>
                {
                    b.HasOne("FoodDelivery.DAL.Entity.Vendor", null)
                        .WithMany("Dishes")
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Basket", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.User", b =>
                {
                    b.Navigation("Basket")
                        .IsRequired();

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDelivery.DAL.Entity.Vendor", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
