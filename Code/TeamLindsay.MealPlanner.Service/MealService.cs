using System;
using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Service.Interface;
using TeamLindsay.MealPlanner.Structure.Model;
using LinqKit;
using System.Linq;
using TeamLindsay.Structure.Enum;

namespace TeamLindsay.MealPlanner.Service
{
    public class MealService : IMealService
    {
        public IMealRepository _mealRepository;
        public IRecipeRepository _recipeRepository;

        public MealService(IMealRepository mealRepository, IRecipeRepository recipeRepository)
        {
            _mealRepository = mealRepository;
            _recipeRepository = recipeRepository;
        }

        public List<MealModel> GetMealsByDates(DateTime startDate, DateTime endDate)
        {
            var returnList = new List<MealModel>();
            var meals = _mealRepository.GetByDate(startDate, endDate);

            foreach(var meal in meals)
            {
                var recipes = _recipeRepository.GetRecipesForMeal(meal.Id);
                returnList.Add(
                    new MealModel
                    {
                        Meal = meal,
                        Recipes = recipes ?? new List<Recipe>()
                    });
            }

            return returnList;
        }

        public List<Meal> GetMeals()
        {
            return _mealRepository.Get();
        }

        public Meal GetMeal(int mealId)
        {
            return _mealRepository.Get(mealId);
        }

        public void Remove(Meal entity)
        {
            _mealRepository.Remove(entity);
        }

        public void Update(Meal entity)
        {
            _mealRepository.Update(entity);
        }

        public List<MealListView> List(MealSearch search)
        {
            if (search == null)
            {
                // default search values
                search = new MealSearch
                {
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(7),
                    MealTypeIds = new List<int> { (int)MealTypes.Breakfast, (int)MealTypes.Dinner }
                };
            }
            var predicate = PredicateBuilder.New<MealListView>(true);

            if (search.StartDate != null)
            {
                predicate.And(s => s.MealDate >= search.StartDate);
            }

            if (search.EndDate != null)
            {
                predicate.And(s => s.MealDate <= search.EndDate);
            }

            if (search.RecipeIds != null && search.RecipeIds.Any())
            {
                predicate.And(s => search.RecipeIds.Contains(s.RecipeId));
            }

            if (search.MealTypeIds != null && search.MealTypeIds.Any())
            {
                predicate.And(s => search.MealTypeIds.Contains(s.MealTypeId));
            }

            return _mealRepository.List(predicate);
        }
    }
}
