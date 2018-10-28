using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using TeamLindsay.MealPlanner.Service.Interface;
using TeamLindsay.MealPlanner.Structure.Entity;

namespace TeamLindsay.Api.Controllers
{
    [RoutePrefix("meals/v1")]
    public class MealController : ApiController
    {
        private IMealService _mealService { get; set; }
        private IRecipeService _recipeService { get; set; }

        public MealController(IMealService mealService, IRecipeService recipeService)
        {
            _mealService = mealService;
            _recipeService = recipeService;
        }

        [HttpGet, Route("get")]
        public List<Meal> List()
        {
            return _mealService.GetMeals();
        }

        [HttpPost, Route("update/{meal}")]
        public void Update(Meal entity)
        {
            _mealService.Update(entity);
        }

        [HttpPost, Route("remove/{meal}")]
        public void Remove(Meal entity)
        {
            _mealService.Remove(entity);
        }

        [HttpPost, Route("list/{search?}")]
        public MealListResponse List (MealSearch search)
        {
            return _mealService.List(search);
        }
    }
}