using System.Collections.Generic;
using System.Linq;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Service.Data;
using TeamLindsay.MealPlanner.Structure.Entity;

namespace TeamLindsay.MealPlanner.Data.Repository
{
    public class MealRecipeRepository : IMealRecipeRepository
    {
        public List<MealRecipe> Get()
        {
            using (var context = Init())
            {
                return context.MealRecipes
                    .OrderBy(mr => mr.Id)
                    .ToList();
            }
        }

        public MealRecipe Get(int id)
        {
            using (var context = Init())
            {
                return context.MealRecipes
                    .FirstOrDefault(mr => mr.Id == id);
            }
        }

        public MealRecipe GetByMeal(int mealId)
        {
            using (var context = Init())
            {
                return context.MealRecipes
                    .FirstOrDefault(mr => mr.MealId == mealId);
            }
        }

        public MealRecipe GetByRecipe(int recipeId)
        {
            using (var context = Init())
            {
                return context.MealRecipes
                    .FirstOrDefault(mr => mr.RecipeId == recipeId);
            }
        }

        protected MealPlannerContext Init()
        {
            return new MealPlannerContext();
        }
    }
}
