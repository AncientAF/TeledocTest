﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TeledocTest.Infrastructure.Data;

#nullable disable

namespace TeledocTest.Infrastructure.Migrations
{
    [DbContext(typeof(TeledocTestDbContext))]
    [Migration("20240530065059_AddedSampleData")]
    partial class AddedSampleData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TeledocTest.Core.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("TaxId")
                        .IsUnique();

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6407),
                            Name = "Client 1",
                            TaxId = "1234567890",
                            Type = 1,
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6408)
                        },
                        new
                        {
                            Id = new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6420),
                            Name = "Client 2",
                            TaxId = "2345678901",
                            Type = 1,
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6420)
                        },
                        new
                        {
                            Id = new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6421),
                            Name = "Client 3",
                            TaxId = "3456789012",
                            Type = 1,
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6422)
                        },
                        new
                        {
                            Id = new Guid("1c164bab-0747-40e2-b885-f1fec5440d42"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6423),
                            Name = "Client 4",
                            TaxId = "344461123113",
                            Type = 0,
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6423)
                        },
                        new
                        {
                            Id = new Guid("93aa14b2-6430-4bf3-bab7-3cd4fb92a804"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6424),
                            Name = "Client 5",
                            TaxId = "125678312356",
                            Type = 0,
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6425)
                        });
                });

            modelBuilder.Entity("TeledocTest.Core.Models.ClientFounder", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FounderId")
                        .HasColumnType("uuid");

                    b.HasKey("ClientId", "FounderId");

                    b.HasIndex("FounderId");

                    b.ToTable("ClientFounder");

                    b.HasData(
                        new
                        {
                            ClientId = new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"),
                            FounderId = new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790")
                        },
                        new
                        {
                            ClientId = new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"),
                            FounderId = new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5")
                        },
                        new
                        {
                            ClientId = new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"),
                            FounderId = new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f")
                        },
                        new
                        {
                            ClientId = new Guid("ee1dab06-c8c2-47dd-8282-16c627c79be9"),
                            FounderId = new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959")
                        },
                        new
                        {
                            ClientId = new Guid("eed4569e-de5e-4155-9c03-1dd658dc774c"),
                            FounderId = new Guid("6d11dd64-336f-47df-8864-507b3fcc766e")
                        },
                        new
                        {
                            ClientId = new Guid("86297138-9adc-4b12-a0e8-8217ce0a6002"),
                            FounderId = new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b")
                        });
                });

            modelBuilder.Entity("TeledocTest.Core.Models.Founder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("TaxId")
                        .IsUnique();

                    b.ToTable("Founders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0cd5c44a-c498-4d21-a47a-a0dda3c2d790"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6529),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 1",
                            TaxId = "123456789022",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6529)
                        },
                        new
                        {
                            Id = new Guid("cd72aff6-e787-405e-a4d8-77eec25460c5"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6531),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 2",
                            TaxId = "234567890133",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6531)
                        },
                        new
                        {
                            Id = new Guid("4d8bb61a-2df3-4a06-949a-23e8af1b686f"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6533),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 3",
                            TaxId = "345678901244",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6533)
                        },
                        new
                        {
                            Id = new Guid("da3cce6d-2e15-4616-80a4-a76b2b669959"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6535),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 4",
                            TaxId = "234567890155",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6535)
                        },
                        new
                        {
                            Id = new Guid("6d11dd64-336f-47df-8864-507b3fcc766e"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6536),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 5",
                            TaxId = "345678901266",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6537)
                        },
                        new
                        {
                            Id = new Guid("9b466d1b-1a35-4fa0-bda9-38e172e3799b"),
                            CreatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6538),
                            LastName = "L",
                            MiddleName = "M",
                            Name = "Founder 6",
                            TaxId = "345678901277",
                            UpdatedAt = new DateTime(2024, 5, 30, 6, 50, 59, 28, DateTimeKind.Utc).AddTicks(6539)
                        });
                });

            modelBuilder.Entity("TeledocTest.Core.Models.ClientFounder", b =>
                {
                    b.HasOne("TeledocTest.Core.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeledocTest.Core.Models.Founder", null)
                        .WithMany()
                        .HasForeignKey("FounderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
