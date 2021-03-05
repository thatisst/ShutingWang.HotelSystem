﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShutingWang.HotelSystem.Infrastructure.Data;

namespace ShutingWang.HotelSystem.Infrastructure.Migrations
{
    [DbContext(typeof(HotelSystemDbContext))]
    partial class HotelSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingDays")
                        .HasColumnType("int");

                    b.Property<string>("CName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<int>("TotalPersons")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomNo");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RtCode")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RtCode");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Roomtype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Rent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RtDesc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Roomtype");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<string>("SDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomNo");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Customer", b =>
                {
                    b.HasOne("ShutingWang.HotelSystem.Core.Entities.Room", "Room")
                        .WithMany("Customers")
                        .HasForeignKey("RoomNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Room", b =>
                {
                    b.HasOne("ShutingWang.HotelSystem.Core.Entities.Roomtype", "Roomtype")
                        .WithMany("Rooms")
                        .HasForeignKey("RtCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roomtype");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Service", b =>
                {
                    b.HasOne("ShutingWang.HotelSystem.Core.Entities.Room", "Room")
                        .WithMany("Services")
                        .HasForeignKey("RoomNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Room", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("ShutingWang.HotelSystem.Core.Entities.Roomtype", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
