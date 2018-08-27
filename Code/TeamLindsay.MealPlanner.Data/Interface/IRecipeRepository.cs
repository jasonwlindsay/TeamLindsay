using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Data.Interface
{
    public interface IRecipeRepository : IRepository
    {
        List<Recipe> Get();
        Recipe Get(int recipeId);
        void Remove(Recipe entity);
        void Update(Recipe entity);
        List<Recipe> GetRecipesForMeal(int mealId);
    }
}
