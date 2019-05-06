﻿// <auto-generated />
using System;
using EmpSpaceDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmpSpaceDataAccess.Migrations
{
    [DbContext(typeof(EmpSpaceContext))]
    [Migration("20190506155225_allow endDate null")]
    partial class allowendDatenull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmpSpaceDataAccess.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<int?>("OfficeId");

                    b.Property<int>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<int>("SupervisorId");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmpSpaceDataAccess.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.Property<string>("PostalCode");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("EmpSpaceDataAccess.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Name");

                    b.Property<decimal>("Salary");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("EmpSpaceDataAccess.Models.Employee", b =>
                {
                    b.HasOne("EmpSpaceDataAccess.Models.Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId");
                });

            modelBuilder.Entity("EmpSpaceDataAccess.Models.Position", b =>
                {
                    b.HasOne("EmpSpaceDataAccess.Models.Employee")
                        .WithMany("Position")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
