﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YogurtFinder.Models;

namespace YogurtFinder.Migrations
{
    [DbContext(typeof(YogurtFinderContext))]
    [Migration("20200817201134_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YogurtFinder.Models.Nutrition", b =>
                {
                    b.Property<int>("NutritionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calories");

                    b.Property<string>("Carbs");

                    b.Property<string>("Fat");

                    b.Property<string>("Protein");

                    b.Property<string>("Sugar");

                    b.Property<int>("YogurtId");

                    b.HasKey("NutritionId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("YogurtFinder.Models.Yogurt", b =>
                {
                    b.Property<int>("YogurtId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Blended");

                    b.Property<string>("Brand");

                    b.Property<string>("Flavor");

                    b.Property<int>("NutritionId");

                    b.Property<int?>("NutritionId1");

                    b.Property<string>("Type");

                    b.HasKey("YogurtId");

                    b.HasIndex("NutritionId1");

                    b.ToTable("Yogurts");
                });

            modelBuilder.Entity("YogurtFinder.Models.Yogurt", b =>
                {
                    b.HasOne("YogurtFinder.Models.Nutrition", "Nutrition")
                        .WithMany()
                        .HasForeignKey("NutritionId1");
                });
#pragma warning restore 612, 618
        }
    }
}
