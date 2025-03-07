using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VaraPrasad.Models;

public partial class CMRDbContext : DbContext
{
    public CMRDbContext()
    {
    }

    public CMRDbContext(DbContextOptions<CMRDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VaprasadDatabase;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValue("");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Addr).HasDefaultValue("");
            entity.Property(e => e.Age).HasColumnName("age");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
