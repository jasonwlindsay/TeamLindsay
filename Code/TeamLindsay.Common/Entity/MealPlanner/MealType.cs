using TeamLindsay.Common.Interface;

namespace TeamLindsay.Common.Entity.MealPlanner
{
    public class MealType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
