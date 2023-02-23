﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;

#nullable disable

namespace VSoft.Company.CTM.Customer.Data.Migrate.Test.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20230223081854_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("VSoft.Company.CTM.Customer.Data.Entity.Models.MCustomerEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<long?>("CustomerInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValueSql("'NULL'")
                        .HasComment("True: Male, False: Female");

                    b.Property<bool>("IsBought")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CustomerInfoId" }, "FK_CustomerInfo_TO_Customer");

                    b.HasIndex(new[] { "PriorityId" }, "FK_Priority_TO_Customer");

                    b.HasIndex(new[] { "Phone" }, "UQ_Phone")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}