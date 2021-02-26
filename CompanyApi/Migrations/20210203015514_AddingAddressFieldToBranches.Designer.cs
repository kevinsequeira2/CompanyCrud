﻿// <auto-generated />
using CompanyApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CompanyApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210203015514_AddingAddressFieldToBranches")]
    partial class AddingAddressFieldToBranches
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CompanyApi.Models.Branch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("company_id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("pk_branches");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_branches_company_id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("CompanyApi.Models.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("GovernmentId")
                        .HasColumnType("text")
                        .HasColumnName("government_id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("CompanyApi.Models.Branch", b =>
                {
                    b.HasOne("CompanyApi.Models.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_branches_companies_company_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CompanyApi.Models.Company", b =>
                {
                    b.Navigation("Branches");
                });
#pragma warning restore 612, 618
        }
    }
}
