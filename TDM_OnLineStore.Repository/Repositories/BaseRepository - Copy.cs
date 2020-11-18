//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using TDM_OnLineStore.Dominium.Models.Interface;

//namespace TDM_OnLineStore.Repository.Repositories
//{
//    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
//    {
//        #region Given access to the Context
//        protected readonly AppDbContext AppDbContext;

//        public BaseRepository(AppDbContext appDbContext)
//        {
//            AppDbContext = appDbContext;
//        }
//        #endregion

//        #region CREATE
//        public void Add(TEntity entity)
//        {
//            AppDbContext.Set<TEntity>().Add(entity);
//            AppDbContext.SaveChanges();
//        }
//        #endregion

//        #region READ
//        public IEnumerable<TEntity> GetAll()
//        {
//            return AppDbContext.Set<TEntity>().ToList();
//        }

//        public TEntity GetById(int id)
//        {
//            return AppDbContext.Set<TEntity>().Find(id);
//        }
//        #endregion

//        #region UPDATE
//        public void Update(TEntity entity)
//        {
//            AppDbContext.Set<TEntity>().Update(entity);
//            AppDbContext.SaveChanges();
//        }
//        #endregion

//        #region DELETE
//        public void Delete(TEntity entity)
//        {
//            AppDbContext.Set<TEntity>().Remove(entity);
//            AppDbContext.SaveChanges();
//        }

//        /// Discart from the memory
//        public void Dispose()
//        {
//            AppDbContext.Dispose();
//        }
//        #endregion
//    }
//}
