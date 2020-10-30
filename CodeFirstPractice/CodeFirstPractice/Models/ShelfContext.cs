using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPractice.Models
{
    class ShelfContext : DbContext
    {
        public virtual DbSet<Shelf> Shelves { get; set; }


        // Connection to Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection =
                    "server=localhost;" +
                    "port=3306;" +
                    "user=root;" +
                    "database=codefirst_practice;";

                string version = "10.4.14-MariaDB";

                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Shelf_Material Table Entity
            modelBuilder.Entity<Shelf_Material>(entity =>
            {
                entity.Property(e => e.MaterialName)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");
               
            });

            // Shelf Table Entity
            modelBuilder.Entity<Shelf>(entity =>
            {
                string keyName = "FK_" + nameof(Shelf) +
                   "_" + nameof(Shelf_Material);

                entity.Property(e => e.Name)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.HasIndex(e => e.ShelfMaterialID)
                .HasName(keyName);

                entity.HasOne(thisEntity => thisEntity.Shelf_Material)
                .WithMany(parent => parent.Shelves)
                .HasForeignKey(thisEntity => thisEntity.ShelfMaterialID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName(keyName);
            });
        }
    }
}
