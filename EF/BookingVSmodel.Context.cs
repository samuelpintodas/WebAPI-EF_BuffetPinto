﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookingValaisPintoDaSilvaEntities : DbContext
    {
        public BookingValaisPintoDaSilvaEntities()
            : base("name=BookingValaisPintoDaSilvaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<ReservationRoom> ReservationRoom { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
