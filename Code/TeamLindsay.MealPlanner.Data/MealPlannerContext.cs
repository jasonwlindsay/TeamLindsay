using System.Data.Entity;
using TeamLindsay.Structure.Entity.MealPlanner;

namespace TeamLindsay.MealPlanner.Service.Data
{
    public class MealPlannerContext : DbContext
    {
        public MealPlannerContext() : base("name=MealPlanner")
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
