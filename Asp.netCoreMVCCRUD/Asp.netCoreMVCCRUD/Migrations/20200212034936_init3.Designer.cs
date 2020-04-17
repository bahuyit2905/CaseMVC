﻿// <auto-generated />
using Asp.netCoreMVCCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.netCoreMVCCRUD.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200212034936_init3")]
    partial class init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.netCoreMVCCRUD.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpCode")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OfficeLocation")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(150)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
