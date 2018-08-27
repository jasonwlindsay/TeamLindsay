using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Service.Interface
{
    public interface IRecipeService : IService
    {
        List<Recipe> GetRecipes();
        Recipe GetRecipe(int recipeId);
        void Update(Recipe entity);
        void Remove(Recipe entity);
    }
}
