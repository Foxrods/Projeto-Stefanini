﻿// <auto-generated />
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examples.Charge.Infra.Data.Configuration.Migrations
{
    [DbContext(typeof(ExampleContext))]
    [Migration("20210526122703_AdionandoPersons")]
    partial class AdionandoPersons
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Examples.Charge.Domain.Aggregates.ExampleAggregate.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Example","dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Example 1"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Example 2"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Example 3"
                        });
                });

            modelBuilder.Entity("Examples.Charge.Domain.Aggregates.PersonAggregate.Person", b =>
                {
                    b.Property<int>("BusinessEntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BusinessEntityID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("BusinessEntityID");

                    b.ToTable("Person","dbo");

                    b.HasData(
                        new
                        {
                            BusinessEntityID = 1,
                            Name = "User One"
                        },
                        new
                        {
                            BusinessEntityID = 2,
                            Name = "Ken Masters"
                        },
                        new
                        {
                            BusinessEntityID = 3,
                            Name = "Laura Matsuda"
                        });
                });

            modelBuilder.Entity("Examples.Charge.Domain.Aggregates.PersonAggregate.PersonPhone", b =>
                {
                    b.Property<int>("BusinessEntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BusinessEntityID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PhoneNumber");

                    b.Property<int>("PhoneNumberTypeID")
                        .HasColumnName("PhoneNumberTypeID");

                    b.Property<int>("PersonID");

                    b.HasKey("BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID");

                    b.HasAlternateKey("BusinessEntityID");

                    b.HasIndex("PersonID");

                    b.HasIndex("PhoneNumberTypeID");

                    b.ToTable("PersonPhone","dbo");

                    b.HasData(
                        new
                        {
                            BusinessEntityID = 1,
                            PhoneNumber = "(19)99999-2883",
                            PhoneNumberTypeID = 1,
                            PersonID = 1
                        },
                        new
                        {
                            BusinessEntityID = 2,
                            PhoneNumber = "(19)99999-4021",
                            PhoneNumberTypeID = 2,
                            PersonID = 1
                        });
                });

            modelBuilder.Entity("Examples.Charge.Domain.Aggregates.PersonAggregate.PhoneNumberType", b =>
                {
                    b.Property<int>("PhoneNumberTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BusinessEntityID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("PhoneNumberTypeID");

                    b.ToTable("PhoneNumberType","dbo");

                    b.HasData(
                        new
                        {
                            PhoneNumberTypeID = 1,
                            Name = "Local phone"
                        },
                        new
                        {
                            PhoneNumberTypeID = 2,
                            Name = "Cellphone"
                        });
                });

            modelBuilder.Entity("Examples.Charge.Domain.Aggregates.PersonAggregate.PersonPhone", b =>
                {
                    b.HasOne("Examples.Charge.Domain.Aggregates.PersonAggregate.Person", "Person")
                        .WithMany("Phones")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Examples.Charge.Domain.Aggregates.PersonAggregate.PhoneNumberType", "PhoneNumberType")
                        .WithMany()
                        .HasForeignKey("PhoneNumberTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
