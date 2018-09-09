using System;
using System.Collections.Generic;
using TeamLindsay.Structure.Search;

namespace TeamLindsay.MealPlanner.Structure.Entity
{
    public class MealSearch : BaseSearch
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<int> RecipeIds { get; set; }
        public List<int> MealTypeIds { get; set; }

        public MealSearch()
        {
            StartDate = DateTime.Now;
        }
    }
}
