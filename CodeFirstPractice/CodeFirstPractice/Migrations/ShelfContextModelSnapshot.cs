﻿// <auto-generated />
using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstPractice.Migrations
{
    [DbContext(typeof(ShelfContext))]
    partial class ShelfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("ShelfMaterialID")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.HasIndex("ShelfMaterialID")
                        .HasName("FK_Shelf_Shelf_Material");

                    b.ToTable("shelf");
                });

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf_Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("shelf_material");
                });

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.HasOne("CodeFirstPractice.Models.Shelf_Material", "Shelf_Material")
                        .WithMany("Shelves")
                        .HasForeignKey("ShelfMaterialID")
                        .HasConstraintName("FK_Shelf_Shelf_Material")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
