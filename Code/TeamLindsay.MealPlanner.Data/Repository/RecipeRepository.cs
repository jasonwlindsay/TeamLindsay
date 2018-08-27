using System;
using System.Collections.Generic;
using System.Linq;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Service.Data;
using TeamLindsay.MealPlanner.Structure.Entity;

namespace TeamLindsay.MealPlanner.Data.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        public List<Recipe> Get()
        {
            using (var context = Init())
            {
                return context.Recipes
                    .OrderBy(mr => mr.Id)
                    .ToList();
            }
        }

        public Recipe Get(int recipeId)
        {
            using (var context = Init())
            {
                return context.Recipes
                    .FirstOrDefault(mr => mr.Id == recipeId);
            }
        }

        public List<Recipe> GetRecipesForMeal(int mealId)
        {
            using (var context = Init())
            {
                return context.MealRecipes.Where(mr => mr.MealId == mealId)
                    .Join(context.Recipes, mr => mr.RecipeId, r => r.Id, (mr, r) => r)
                    .ToList();
            }
        }

        public void Remove(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe entity)
        {
            throw new NotImplementedException();
        }

        protected MealPlannerContext Init()
        {
            return new MealPlannerContext();
        }
    }
}
