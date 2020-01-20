using HotelData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelData
{
    public class HotelContext :DbContext 
    {
        public HotelContext(DbContextOptions options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelAsset>()
                .HasKey(h => h.RoomNumber);
            
         
            modelBuilder.Entity<Reservation>()
                .HasKey(r => r.ConfirmationNumber);
            
        }
        



        public DbSet<Address> Addresses { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<HotelAsset> HotelAssets { get; set; }
        public DbSet<HotelInfo> HotelInfos { get; set; }
        public DbSet<PaymenInfo> PaymenInfos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<WaitingList> WaitingLists { get; set; }


    }
}
