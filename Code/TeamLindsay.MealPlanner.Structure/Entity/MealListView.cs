using System;

namespace TeamLindsay.MealPlanner.Structure.Entity
{
    public class MealListView
    {
        public int MealId { get; set; }
        public DateTime MealDate { get; set; }
        public int MealTypeId { get; set; }
        public string MealType { get; set; }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
