using Microsoft.EntityFrameworkCore;
using Model;
using Model.Mappings;

namespace Api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
        }

        public DbSet<PersonModel> Person => Set<PersonModel>();
    }
}