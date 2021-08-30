﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftLineTestTask.Models;

namespace SoftLineTestTask.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210830181401_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoftLineTestTask.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Decree")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 4,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 5,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 6,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 7,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 8,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 9,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        },
                        new
                        {
                            Id = 10,
                            Birthday = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Decree = true,
                            Name = "Tom",
                            Position = "1",
                            Text = "1"
                        });
                });

            modelBuilder.Entity("SoftLineTestTask.Models.SubTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SubTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 5,
                            FieldName = "Рад работать в компании",
                            FieldText = "да"
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 6,
                            FieldName = "Всегда в хорошем настроении",
                            FieldText = "да"
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 10,
                            FieldName = "Первое поле",
                            FieldText = "действительно первое"
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 10,
                            FieldName = "Второе поле",
                            FieldText = "действительно второе"
                        });
                });

            modelBuilder.Entity("SoftLineTestTask.Models.SubTable", b =>
                {
                    b.HasOne("SoftLineTestTask.Models.Employee", "Employee")
                        .WithMany("SubTable")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SoftLineTestTask.Models.Employee", b =>
                {
                    b.Navigation("SubTable");
                });
#pragma warning restore 612, 618
        }
    }
}