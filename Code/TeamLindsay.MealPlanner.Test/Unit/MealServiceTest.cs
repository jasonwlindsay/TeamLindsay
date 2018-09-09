using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TeamLindsay.MealPlanner.Data.Interface;
using TeamLindsay.MealPlanner.Structure.Entity;
using TeamLindsay.Structure.Enum;
using System.Linq.Expressions;
using TeamLindsay.MealPlanner.Service.Interface;
using TeamLindsay.MealPlanner.Service;

namespace TeamLindsay.Test.Unit
{
    [TestClass]
    public class MealServiceTest
    {
        private Mock<IMealRepository> _mealRepository;
        private Mock<IRecipeRepository> _recipeRepository;
        private IMealService _mealService;

        [TestInitialize]
        public void Init()
        {
            _mealRepository = new Mock<IMealRepository>();
            _recipeRepository = new Mock<IRecipeRepository>();

            _mealRepository.Setup(m => m.List(It.IsAny<Expression<Func<MealListView, bool>>>()))
                .Returns(DefaultSearchResultList);
            _mealService = new MealService(_mealRepository.Object, _recipeRepository.Object);
        }

        [TestMethod]
        public void Meal_list_return_results()
        {
            var search = new MealSearch();
            var results = _mealService.List(search);
            Assert.IsNotNull(results);
        }

        private List<MealListView> DefaultSearchResultList() => new List<MealListView>
        {
            new MealListView
            {
                MealId = 101,
                RecipeId = 1,
                MealTypeId = (int)MealTypes.Breakfast,
                MealDate = DateTime.Now.AddDays(-10),
                Ingredients = string.Empty,
                Instructions = string.Empty
            },
            new MealListView
            {
                MealId = 201,
                RecipeId = 2,
                MealTypeId = (int)MealTypes.Dinner,
                MealDate = DateTime.Now,
                Ingredients = string.Empty,
                Instructions = string.Empty
            },
            new MealListView
            {
                MealId = 401,
                RecipeId = 4,
                MealTypeId = (int)MealTypes.Lunch,
                MealDate = DateTime.Now.AddDays(10),
                Ingredients = string.Empty,
                Instructions = string.Empty
            }
        };
    }
}
