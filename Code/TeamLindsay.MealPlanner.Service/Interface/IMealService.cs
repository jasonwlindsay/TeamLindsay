using System;
using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.MealPlanner.Structure.Model;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Service.Interface
{
    public interface IMealService : IService
    {
        List<Meal> GetMeals();
        Meal GetMeal(int mealId);
        List<MealModel> GetMealsByDates(DateTime startDate, DateTime endDate);
        void Update(Meal entity);
        void Remove(Meal entity);
        MealListResponse List(MealSearch search);
    }
}
