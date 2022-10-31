﻿// <auto-generated />
using System;
using MIS_Prog_AppTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MIS_Prog_AppTest.Migrations
{
    [DbContext(typeof(EventManagerDBContext))]
    partial class EventManagerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("MIS_Prog_AppTest.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("eventEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("eventStartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MIS_Prog_AppTest.Models.Registration", b =>
                {
                    b.Property<int>("RegID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("emailAdd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RegID");

                    b.ToTable("RSVP");
                });
#pragma warning restore 612, 618
        }
    }
}
