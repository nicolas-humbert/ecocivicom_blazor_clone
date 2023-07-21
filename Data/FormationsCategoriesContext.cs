using Microsoft.EntityFrameworkCore;

namespace ecocivicom_blazor_clone.Data
{
    public class FormationsCategoriesDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<FormationsCategory> FormationsCategories { get; set; }

        public FormationsCategoriesDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EcocivicomDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormationsCategory>()
                .ToTable("FormationsCategories");

            List<FormationsCategory> formsCategories = FormationsCategory.ParseAndCreateFormationsCategories();

            modelBuilder.Entity<FormationsCategory>()
                .HasData(formsCategories);
        }
    }

}