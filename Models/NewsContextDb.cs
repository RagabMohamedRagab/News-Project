using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class NewsContextDb:DbContext
    {
        public NewsContextDb(DbContextOptions<NewsContextDb> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Ignore(b =>  b.File);
            modelBuilder.Entity<User>().Ignore(b =>  b.GetCountry);
            modelBuilder.Entity<User>().HasIndex(i => new { i.ID, i.FirstName, i.LastName, i.Password, i.Email });
            modelBuilder.Entity<Comment>().HasKey(PK => PK.Id);
            modelBuilder.Entity<Comment>().Property(text => text.Text).IsRequired().HasColumnType("nvarchar(350)");
            modelBuilder.Entity<Comment>().Property(PK => PK.Id).ValueGeneratedOnAdd();
          
        }

        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
