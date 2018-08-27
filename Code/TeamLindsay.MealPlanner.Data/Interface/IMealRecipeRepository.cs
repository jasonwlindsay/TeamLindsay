using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
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
