using System.Collections.Generic;

namespace TeamLindsay.MealPlanner.Structure.Entity
{
    public class MealListResponse
    {
        public List<MealListView> Results { get; set; }
        public MealSearch Search { get; set; }
    }
}
