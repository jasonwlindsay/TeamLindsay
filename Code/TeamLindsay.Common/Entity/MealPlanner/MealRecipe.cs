using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamLindsay.Common.Interface;

namespace TeamLindsay.Common.Entity.MealPlanner
{
    public class MealRecipe : IEntity
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int RecipeId { get; set; }
    }
}
