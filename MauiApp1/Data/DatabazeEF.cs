using MauiApp1.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace MauiApp1.Data
{
    public class DatabazeEF : DbContext
    {
        //public DatabazeEF(DbContextOptions options) : base(options)
        //{
        //    Database.EnsureCreated();
        //    Batteries_V2.Init();
        //}

        public DatabazeEF()
        {
            Database.EnsureCreated();
            Batteries_V2.Init();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source = I4B.db");
        }


        public DbSet<Clovek> Lidi { get; set; }
        public DbSet<Auto> Auta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Clovek c1 = new Clovek() { Id = 1, Jmeno="Ondra"};
            Auto a1 = new Auto { Znacka="Škoda", Model="Karoq", Id=1, Palivo=Palivo.Diesel, ClovekId=1 };
            Auto a2 = new Auto { Znacka="Peugeot", Model="206", Id=2, Palivo=Palivo.Benzin, ClovekId=1 };

            modelBuilder.Entity<Clovek>().HasData(c1);
            modelBuilder.Entity<Auto>().HasData(a1,a2);
        }
    }
}
