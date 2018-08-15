using System.Data.Entity;
using TeamLindsay.Common.Entity.MealPlanner;

namespace TeamLindsay.Provider.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=MealPlanner")
        { }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<MealRecipe> MealRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>().ToTable("Meals", "dbo").HasKey(c => c.Id);
            modelBuilder.Entity<MealType>().ToTable("MealTypes", "dbo").HasKey(t => t.Id);
            modelBuilder.Entity<MealRecipe>().ToTable("MealRecipes", "dbo").HasKey(t => t.Id);
            modelBuilder.Entity<Recipe>().ToTable("Recipes", "dbo").HasKey(t => t.Id);
        }
    }
}
