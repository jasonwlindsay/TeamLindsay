//using TeamLindsay.Provider;
//using TeamLindsay.Provider.Data;
//using System.Collections.Generic;
//using System.Web.Http;
//using System.Web.Http.Cors;

//namespace TeamLindsay.Controllers
//{
//    [RoutePrefix("transaction")]
//    public class TransactionController : ApiController
//    {
//        private TransactionProvider _transactionProvider { get; set; }
//        private CategoryProvider _categoryProvider { get; set; }

//        public TransactionController()
//        {
//            _transactionProvider = new TransactionProvider();
//            _categoryProvider = new CategoryProvider();
//        }

//        [HttpGet, Route("categories")]
//        public List<Category> Categories()
//        {
//            return _categoryProvider.Load();
//        }

//        [HttpGet, Route("list")]
//        public List<Transaction> List()
//        {
//            return _transactionProvider.Load();
//        }

//        [HttpPost, Route("update/{transaction}")]
//        public void Update(Transaction transaction)
//        {
//            _transactionProvider.Update(transaction);
//        }

//        [HttpPost, Route("remove/{transaction}")]
//        public void Remove(Transaction transaction)
//        {
//            _transactionProvider.Remove(transaction);
//        }
//    }
//}