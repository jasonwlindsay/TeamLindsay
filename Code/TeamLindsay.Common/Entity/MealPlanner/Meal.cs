using System;

namespace TeamLindsay.Structure.Entity.MealPlanner
{
    public class Meal : BaseEntity
    {
        public DateTime MealDate { get; set; }
        public int MealTypeId { get; set; }
    }
}
