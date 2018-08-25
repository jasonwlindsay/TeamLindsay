using System;
using System.Collections.Generic;
using TeamLindsay.Structure.Entity.MealPlanner;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Data.Interface
{
    public interface IMealRepository : IRepository
    {
        List<Meal> GetByDate(DateTime startDate, DateTime endDate);
        void Update(Meal entity);
        void Remove(Meal entity);
        List<Meal> Get();
        Meal Get(int mealId);
    }
}
