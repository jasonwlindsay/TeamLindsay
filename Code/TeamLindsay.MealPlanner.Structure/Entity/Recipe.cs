using TeamLindsay.Structure.Entity;

namespace TeamLindsay.MealPlanner.Structure.Entity
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
