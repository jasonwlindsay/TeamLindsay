//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TeamLindsay.MealPlanner.Service;
//using System.Linq;

//namespace TeamLindsay.Test
//{
//    [TestClass]
//    public class CategoryProviderTest
//    {
//        private CategoryProvider _provider { get; set; }

//        [TestInitialize]
//        public void Initialize()
//        {
//            _provider = new CategoryProvider();
//        }

//        [TestMethod]
//        public void Should_return_list()
//        {
//            var results = _provider.Load();
//            Assert.IsNotNull(results);
//            Assert.IsTrue(results.Count > 0);
//            Assert.IsTrue(results.All(c => !string.IsNullOrEmpty(c.Name)));
//        }
//    }
//}
