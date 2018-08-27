using System;
using System.Collections.Generic;
using System.Linq;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Service.Data;
using TeamLindsay.MealPlanner.Structure.Entity;

namespace TeamLindsay.MealPlanner.Data.Repository
{
    public class MealRepository : IMealRepository
    {
        public List<Meal> Get()
        {
            using (var context = Init())
            {
                return context.Meals
                    .OrderBy(mr => mr.Id)
                    .ToList();
            }
        }

        public Meal Get(int id)
        {
            using (var context = Init())
            {
                return context.Meals
                    .FirstOrDefault(mr => mr.Id == id);
            }
        }

        public List<Meal> GetByDate(DateTime startDate, DateTime endDate)
        {
            using (var context = Init())
            {
                var results = context.Meals.Where(m => m.MealDate >= startDate && m.MealDate <= endDate).ToList();
                return results;
            }
        }
        public List<MealListView> List()
        {
            using (var context = Init())
            {
                return context.MealListView.ToList();
            }
        }

        public void Remove(Meal entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Meal entity)
        {
            throw new NotImplementedException();
        }

        protected MealPlannerContext Init()
        {
            return new MealPlannerContext();
        }
    }
}
