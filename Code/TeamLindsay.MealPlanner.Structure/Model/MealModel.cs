using System.Collections.Generic;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Structure.Model
{
    public class MealModel : IModel
    {
        public Meal Meal { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
