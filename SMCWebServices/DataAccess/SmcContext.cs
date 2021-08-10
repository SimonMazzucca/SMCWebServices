﻿using Microsoft.EntityFrameworkCore;
using SMCWebServices.DataAccess.Domain;

#nullable disable

namespace SMCWebServices.DataAccess
{
    public partial class SmcContext : DbContext
    {
        public SmcContext()
        {
        }

        public SmcContext(DbContextOptions<SmcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=SMC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(x => x.OrderId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(x => x.ProductId);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(x => x.OrderDetailId);

                entity
                    .HasOne(od => od.Product)
                    .WithMany(p => p.Orders);

                entity
                    .HasOne(od => od.Order)
                    .WithMany(o => o.Orders);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}