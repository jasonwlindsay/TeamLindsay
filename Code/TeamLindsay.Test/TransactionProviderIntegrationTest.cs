//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TeamLindsay.Provider;
//using TeamLindsay.Provider.Data;
//using TeamLindsay.Provider.Enum;

//namespace TeamLindsay.Test
//{
//    [TestClass]
//    public class TransactionProviderIntegrationTest
//    {
//        private TransactionProvider _provider { get; set; }

//        [TestInitialize]
//        public void Initialize()
//        {
//            _provider = new TransactionProvider();
//        }

//        [TestMethod]
//        public void Should_return_transactions()
//        {
//            var results = _provider.Load();
//            Assert.IsNotNull(results);
//            Assert.IsTrue(results.Count > 0);
//        }

//        [TestMethod]
//        public void Should_return_a_single_transaction()
//        {
//            var result = _provider.Load(1);
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.TransactionId == 1);
//        }

//        [TestMethod]
//        public void Should_return_null_on_invalid_load()
//        {

//            var result = _provider.Load(666);
//            Assert.IsNull(result);            
//        }

//        [TestMethod]
//        public void Should_insert_update_remove()
//        {
//            // add
//            var entity = new Transaction
//            {
//                CategoryId = (int)Categories.Entertainment,
//                PayeeName = "Mister Krabs",
//                PurchaseAmount = 1.00M,
//                PurchaseDate = DateTime.Now.AddDays(-10),
//                Memo = "Me Secret Forumla!!"
//            };

//            var result = _provider.Update(entity);
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.TransactionId != 0);

//            // update
//            entity.PurchaseAmount = 2.00M;
//            entity.PurchaseDate = entity.PurchaseDate.AddDays(1);

//            var updateResult = _provider.Update(entity);

//            Assert.IsTrue(result.PurchaseAmount == 2.00M);

//            // remove
//            var removeId = entity.TransactionId;

//            _provider.Remove(entity);

//            var removeResult = _provider.Load(removeId);
//            Assert.IsNull(removeResult);
//        }
//    }
//}
