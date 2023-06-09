﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp1.Models;

#nullable disable

namespace WpfApp1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230604192817_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("WpfApp1.Models.AdressBook", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("AdressBooks");
                });

            modelBuilder.Entity("WpfApp1.Models.DataAdressBook", b =>
                {
                    b.Property<string>("Name2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostInd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name2");

                    b.ToTable("DataAdresses");
                });
#pragma warning restore 612, 618
        }
    }
}
