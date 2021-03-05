using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShutingWang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Data
{
    public class HotelSystemDbContext : DbContext
    {
        public HotelSystemDbContext(DbContextOptions<HotelSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Roomtype> Roomtypes { get; set; }
        public DbSet<Service> Services { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roomtype>(ConfigureRoomType);
            modelBuilder.Entity<Room>(ConfigureRoom);
            modelBuilder.Entity<Service>(ConfigureService);
            modelBuilder.Entity<Customer>(ConfigureCustomer);
        }

        private void ConfigureRoomType(EntityTypeBuilder<Roomtype> builder)
        {
            builder.ToTable("Roomtype");
            builder.HasKey(rt => rt.Id);
            
            builder.Property(rt => rt.RtDesc).HasMaxLength(20);
        }

        private void ConfigureRoom(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room");
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.Roomtype)
                .WithMany(rt => rt.Rooms)
                .HasForeignKey(r => r.RtCode);
        }

        private void ConfigureService(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(s => s.Id);
            builder.Property(rt => rt.SDesc).HasMaxLength(50);
            builder.HasOne(s => s.Room)
                .WithMany(r => r.Services)
                .HasForeignKey(s => s.RoomNo);
               
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CName).HasMaxLength(20);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.Phone).HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(40);

            builder.HasOne(c => c.Room)
                .WithMany(r => r.Customers)
                .HasForeignKey(c => c.RoomNo);
        }

    }
}
