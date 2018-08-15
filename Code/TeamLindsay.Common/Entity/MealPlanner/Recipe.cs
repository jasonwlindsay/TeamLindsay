using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamLindsay.Common.Interface;

namespace TeamLindsay.Common.Entity.MealPlanner
{
    public class Recipe : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
