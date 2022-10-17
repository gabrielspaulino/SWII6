﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP02.Repository;

#nullable disable

namespace TP02.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221017030710_TP_02")]
    partial class TP_02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TP02.Models.BL", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Numero");

                    b.Property<string>("Consignee")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Consignee");

                    b.Property<string>("Navio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Navio");

                    b.HasKey("Numero");

                    b.ToTable("BL");
                });

            modelBuilder.Entity("TP02.Models.Container", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Numero");

                    b.Property<int?>("Container")
                        .HasColumnType("int");

                    b.Property<double>("Tamanho")
                        .HasColumnType("double")
                        .HasColumnName("Tamanho");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Tipo");

                    b.HasKey("Numero");

                    b.HasIndex("Container");

                    b.ToTable("Container");
                });

            modelBuilder.Entity("TP02.Models.Container", b =>
                {
                    b.HasOne("TP02.Models.BL", null)
                        .WithMany("containers")
                        .HasForeignKey("Container");
                });

            modelBuilder.Entity("TP02.Models.BL", b =>
                {
                    b.Navigation("containers");
                });
#pragma warning restore 612, 618
        }
    }
}
