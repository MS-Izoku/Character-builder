﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testMVC.Data;

namespace testMVC.Migrations
{
    [DbContext(typeof(DocumentorContext))]
    [Migration("20200409043110_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("testMVC.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("content")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Document");
                });
#pragma warning restore 612, 618
        }
    }
}
