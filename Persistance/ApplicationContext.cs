using Microsoft.EntityFrameworkCore;
using Persistence.ValueConverters;
using Domain.Entities;
using Persistance.EntititesConfigurations;

namespace Persistance
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base(new DbContextOptionsBuilder()
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JewleryADO_db;Trusted_Connection=True;").Options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureEntities(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>();

            modelBuilder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>();
        }

        private void ConfigureEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new GoodConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }

    }
}
