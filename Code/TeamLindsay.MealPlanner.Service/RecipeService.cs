using System;
using System.Collections.Generic;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Service.Interface;
using TeamLindsay.Structure.Entity.MealPlanner;

namespace TeamLindsay.MealPlanner.Service
{
    public class RecipeService : IRecipeService
    {
        private IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public List<Recipe> GetRecipes()
        {
            return _recipeRepository.Get();
        }
        public Recipe GetRecipe(int recipeId)
        {
            return _recipeRepository.Get(recipeId);
        }

        public void Remove(Recipe entity)
        {
            _recipeRepository.Remove(entity);
        }

        public void Update(Recipe entity)
        {
            _recipeRepository.Update(entity);
        }
    }
}
