using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CashBox> CashBoxes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CashBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CashBoxe__3214EC0793F8F60E");

            entity.Property(e => e.Balance).HasColumnType("decimal(15, 8)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Status).HasDefaultValue(DataStatus.Active);

        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07AE1D3E54");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(40);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Username).HasMaxLength(500);

            entity.HasOne(d => d.Permission).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_Employees_Permissions");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC073A6CC489");

            entity.Property(e => e.Name).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
