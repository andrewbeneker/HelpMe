using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HelpMeAPI.Entities;

public partial class HelpMeDbContext : DbContext
{
    public HelpMeDbContext()
    {
    }

    public HelpMeDbContext(DbContextOptions<HelpMeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ticket__3213E83F4B8A21D5");

            entity.ToTable("Ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(70);
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.ResolvedBy).HasMaxLength(70);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83F0B7D6DE9");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(70);
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.UserName).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
