using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LBI_DAL.Models; 
using Microsoft.Extensions.Configuration.Json; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LBI_DAL
{
    public class LBIContext : DbContext
    {
        public LBIContext()
        {
        }
        public LBIContext(DbContextOptions<LBIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelbuilders user
            modelBuilder.Entity<Users>()
                .HasMany(c => c.UserCategories)
                .WithOne(u => u.User);
            modelBuilder.Entity<Users>()
                .HasMany(h => h.UserHappiness)
                .WithOne(u => u.User); 
            modelBuilder.Entity<Users>()
                .HasMany(s => s.Stats)
                .WithOne(u => u.User);
            modelBuilder.Entity<Users>()
                .HasMany(a => a.Agendas)
                .WithOne(u => u.User);
            modelBuilder.Entity<Users>()
                .HasMany(g => g.Goals)
                .WithOne(u => u.User);
            modelBuilder.Entity<Users>()
                .HasMany(m => m.MomentKaders)
                .WithOne(u => u.User);
            modelBuilder.Entity<Users>()
                .HasMany(e => e.EigenNetwerken)
                .WithOne(u => u.User);

            //modelbuilder categories
            modelBuilder.Entity<Category>()
                .HasMany(u => u.UserCategories)
                .WithOne(c => c.Category); 

            modelBuilder.Entity<Goals>();
            modelBuilder.Entity<Externe_bron>();
            modelBuilder.Entity<Quotes>();

            modelBuilder.Entity<Agenda>()
                .HasMany(a => a.AgendaItems)
                .WithOne(i => i.Agenda);

            //modelbuilders usercategorie
            modelBuilder.Entity<UserCategory>()
                .HasMany(l => l.Logs)
                .WithOne(c => c.UserCategory);
            modelBuilder.Entity<UserCategory>()
                .HasMany(i => i.AgendaItems)
                .WithOne(c => c.UserCategory); 

            modelBuilder.Entity<Happiness>();
            modelBuilder.Entity<EigenNetwerk>();
            modelBuilder.Entity<Mindfulness>();
            modelBuilder.Entity<MomentKader>();

            modelBuilder.Entity<Stats>()
                .HasMany(l => l.Logs)
                .WithOne(s => s.Stat);

            modelBuilder.Entity<Log>(); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstring = ConnectionString;
            optionsBuilder.UseSqlServer(connstring);
            //base.OnConfiguring(optionsBuilder); 
        }
        private static string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var config = builder.Build();

                string connstr = config.GetConnectionString("DefaultConnection");
                return connstr;
            }
        }

        public virtual DbSet<Goals> GoalsDb { get; set; }
        public virtual DbSet<Externe_bron> Externe_bronDb { get; set; }
        public virtual DbSet<Quotes> QuotesDb { get; set; }
        public virtual DbSet<Category> CategoryDb { get; set; }
        public virtual DbSet<Agenda> AgendaDb { get; set; }
        public virtual DbSet<AgendaItem> AgendaItemDb { get; set; }
        public virtual DbSet<Happiness> HappinessDb { get; set; }
        public virtual DbSet<EigenNetwerk> EigenNetwerkDb { get; set; }
        public virtual DbSet<Mindfulness> MindfulnessDb { get; set; }
        public virtual DbSet<MomentKader> MomentKaderDb { get; set; }
        public virtual DbSet<Users> UsersDb { get; set; }
        public virtual DbSet<Stats> Statsdb { get; set; }
        public virtual DbSet<Log> LogDb { get; set; }
        public virtual DbSet<UserCategory> UserCategoryDb { get; set; }
        public virtual DbSet<UserHappiness> UserHappinessDb { get; set; }
    }
}
