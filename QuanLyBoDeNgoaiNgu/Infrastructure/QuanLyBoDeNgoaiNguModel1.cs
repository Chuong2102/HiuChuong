using QuanLyBoDeNgoaiNgu.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBoDeNgoaiNgu.Infrastructure
{
    public partial class QuanLyBoDeNgoaiNguModel1 : DbContext
    {
        public QuanLyBoDeNgoaiNguModel1()
            : base("QuanLyBoDeNgoaiNguModel1")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Composition> Compositions { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Student & StudentAddress entity
            modelBuilder.Entity<User>()
                        .HasOptional(s => s.Account) // Mark Address property optional in Student entity
                        .WithRequired(ad => ad.User); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student

        }
    }

}