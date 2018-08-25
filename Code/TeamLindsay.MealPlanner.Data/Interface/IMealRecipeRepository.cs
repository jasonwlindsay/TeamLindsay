using System.Collections.Generic;
using TeamLindsay.Structure.Entity.MealPlanner;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Data.Interface
{
    public interface IMealRecipeRepository : IRepository
    {
        List<MealRecipe> Get();
        MealRecipe Get(int id);
        MealRecipe GetByMeal(int mealId);
        MealRecipe GetByRecipe(int recipeId);
    }
}
