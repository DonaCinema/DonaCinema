using DonaCinema.BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Repository.Context
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình mối quan hệ giữa Payment và ApplicationUser
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa BookDetail và ApplicationUser
            modelBuilder.Entity<BookDetail>()
                .HasOne(b => b.User)
                .WithMany(u => u.BookDetails)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Ticket và BookDetail
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.BookDetail)
                .WithMany(b => b.Ticket)
                .HasForeignKey(t => t.BookDetailId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Ticket và Seat
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Seat)
                .WithMany()
                .HasForeignKey(t => t.SeatId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Ticket và ShowTime
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.ShowTime)
                .WithMany()
                .HasForeignKey(t => t.ShowTimeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa ShowTime và Movie
            modelBuilder.Entity<ShowTime>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.ShowTimes)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa ShowTime và Screen
            modelBuilder.Entity<ShowTime>()
                .HasOne(s => s.Screen)
                .WithMany(s => s.ShowTimes)
                .HasForeignKey(s => s.ScreenId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Screen và Cinema
            modelBuilder.Entity<Screen>()
                .HasOne(s => s.Cinema)
                .WithMany(c => c.Screens)
                .HasForeignKey(s => s.CinemaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Movie và Promotion
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Promotion)
                .WithMany(p => p.Movies)
                .HasForeignKey(m => m.PromotionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
