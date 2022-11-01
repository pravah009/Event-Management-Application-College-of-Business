﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MIS_Prog_App.Models
{
    public partial class ProgAppContext : DbContext
    {
        public ProgAppContext()
        {
        }

        public ProgAppContext(DbContextOptions<ProgAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:s26.winhost.com;Initial Catalog=DB_128040_ilod0001;Persist Security Info=True;User ID=DB_128040_ilod0001_user;Password=Chukwuma113485862");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventEnd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("eventEnd");

                entity.Property(e => e.EventLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("eventLocation");

                entity.Property(e => e.EventStart)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("eventStart");

                entity.Property(e => e.EventTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("eventTitle");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__Registration__04E782156EA5144A");

                entity.ToTable("Registration");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.Em)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("em");

                entity.Property(e => e.First)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("first");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Last)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("last");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event.ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}