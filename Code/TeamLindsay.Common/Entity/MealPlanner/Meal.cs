using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamLindsay.Common.Interface;

namespace TeamLindsay.Common.Entity.MealPlanner
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public DateTime MealDate { get; set; }
        public int MealTypeId { get; set; }
    }
}
