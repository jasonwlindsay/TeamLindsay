//using System.Data.Entity;
//using TeamLindsay.Structure.Entity;
//using TeamLindsay.MealPlanner.Service.Data;
//using TeamLindsay.Data.Interface;

//namespace TeamLindsay.MealPlanner.Data.Repository
//{
//    public class BaseRepository<T> : IBaseRepository<T>
//        where T : BaseEntity
//    {
//        public void Update(T entity)
//        {
//            using (var context = Init())
//            {
//                context.Entry(entity).State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;
//                context.SaveChanges();
//            }
//        }

//        public void Remove(T entity)
//        {
//            using (var context = Init())
//            {
//                context.Entry(entity).State = EntityState.Deleted;
//                context.SaveChanges();
//            }
//        }

//        protected MealPlannerContext Init()
//        {
//            return new MealPlannerContext();
//        }
//    }
//}
