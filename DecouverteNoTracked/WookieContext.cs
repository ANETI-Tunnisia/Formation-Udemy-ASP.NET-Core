using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteNoTracked
{
    public class WookieContext:DbContext
    {
        public WookieContext(DbContextOptions options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;
        }
        protected WookieContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

            base.OnConfiguring(optionBuilder);
        }

        public DbSet<Wookie> wookies { get; set; }
    }
}
