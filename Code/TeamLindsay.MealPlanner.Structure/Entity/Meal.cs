using System;
using TeamLindsay.Structure.Entity;

namespace TeamLindsay.MealPlanner.Structure.Entity
{
    public class Meal : BaseEntity
    {
        public DateTime MealDate { get; set; }
        public int MealTypeId { get; set; }
    }
}
