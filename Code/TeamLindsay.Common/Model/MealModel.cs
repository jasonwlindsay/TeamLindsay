using System.Collections.Generic;
using TeamLindsay.Structure.Entity.MealPlanner;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.Structure.Model
{
    public class MealModel : IModel
    {
        public Meal Meal { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
