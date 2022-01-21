using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class NewsContext:DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
    }
}
