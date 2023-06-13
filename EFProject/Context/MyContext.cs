using EFProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Context
{
    internal class MyContext:DbContext
    {
        public MyContext()
        {
            
        }
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EFProject;Trusted_connection=true;TrustServerCertificate=True") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Customer Model
            modelBuilder.Entity<Customer>().Property(c => c.CustomerId).HasMaxLength(10);
            modelBuilder.Entity<Customer>().Property(c => c.PhoneNumber).HasMaxLength(10);

            //convert to date DT in the DB
            modelBuilder.Entity<Customer>().Property(C => C.BirthDate).HasColumnType("Date");
            
            //**************************************************************************
            //Movie Model
            modelBuilder.Entity<Movie>().Property(m=>m.MovieId).HasMaxLength(10);
            modelBuilder.Entity<Movie>().Property(m => m.ProducerId).HasMaxLength(10);
            modelBuilder.Entity<Movie>().Property(m => m.Duration).HasMaxLength(10);

            //***************************************************************************
            //Producer Model
            modelBuilder.Entity<Producer>().Property(p => p.ProducerId).HasMaxLength(10);

            //***************************************************************************
            //Customer_Movie Model
            modelBuilder.Entity<Customer_Movie>().HasKey(ww => new {ww.CustomerId,ww.MovieId});
            modelBuilder.Entity<Customer_Movie>().Property(ww => ww.CustomerId).HasMaxLength(10);
            modelBuilder.Entity<Customer_Movie>().Property(ww => ww.MovieId).HasMaxLength(10);
            // convert to date DT in the DB
            modelBuilder.Entity<Customer_Movie>().Property(ww => ww.Date_Rented).HasColumnType("Date");
            modelBuilder.Entity<Customer_Movie>().Property(ww => ww.Due_Date).HasColumnType("Date");




            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Customer_Movie> Customer_Movies { get; set; }

    }
}
