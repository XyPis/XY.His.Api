﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Linq.Expressions;
using Microsoft.Practices.Unity;
using Z.EntityFramework.Extensions;
using log4net;

namespace XY.His.Core
{
    public class EFUnitOfWork<TDbContext> : IUnitOfWork 
        where TDbContext : DbContext
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);              

        private bool disposed = false;
        private bool bulkFlag = false;
        private IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        public EFUnitOfWork(DbContext context)
        {
            EFContext = context;
        }

        public DbContext EFContext { get; set; }

        public bool IsConnectionOpen { get { return EFContext != null; } }        

        public void Add<TEntity>(TEntity entity) 
            where TEntity : class, new()
        {
            GetRepository<TEntity>().Add(entity);
        }

        public void Delete<TEntity>(TEntity entity)
            where TEntity : class, new()
        {
            GetRepository<TEntity>().Delete(entity);
        }

        public void DeleteById<TEntity>(params object[] ids)
            where TEntity : class, new()
        {
            GetRepository<TEntity>().DeleteById(ids);
        }

        public virtual int DeleteAll<TEntity>()
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().DeleteAll();
        }

        public void Update<TEntity>(TEntity entity) 
            where TEntity : class, new()
        {
            GetRepository<TEntity>().Update(entity);
        }

        public TEntity GetById<TEntity>(params object[] ids) 
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().GetById(ids);
        }

        public IQueryable<TEntity> Get<TEntity>() 
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().Get();
        }

        public void Query(Action query)
        {
            query.Invoke();

            SaveChanges(true);
        }

        public void SaveChanges(bool withDisposing = false)
        {
            try
            {
                if (bulkFlag)
                {
                    EFContext.BulkSaveChanges();
                    bulkFlag = false;
                }
                else
                {
                    EFContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (withDisposing)
                {
                    Dispose();
                }
            }
        }        

        public IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
            where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            return GetRepository<TEntityOuter>().Get().Join(GetRepository<TEntityInner>().Get(), outerKeySelector, innerKeySelector, resultSelector).AsQueryable();
        }

        public IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
            where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            return GetRepository<TEntityOuter>().Get().Join(GetRepository<TEntityInner>().Get(), outerKeySelector, innerKeySelector, resultSelector, comparer).AsQueryable();
        }

        public IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
            where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            return GetRepository<TEntityOuter>().Get().GroupJoin(GetRepository<TEntityInner>().Get(), outerKeySelector, innerKeySelector, (p, q) => resultSelector(p, q.FirstOrDefault())).AsQueryable();
        }

        public IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
            where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            return GetRepository<TEntityOuter>().Get().GroupJoin(GetRepository<TEntityInner>().Get(), outerKeySelector, innerKeySelector, (p, q) => resultSelector(p, q.FirstOrDefault()), comparer).AsQueryable();
        }

        private IRepository<TEntity> GetRepository<TEntity>()
           where TEntity : class, new()
        {
            if (!repositories.ContainsKey(typeof(TEntity)))
            {
                repositories.Add(new KeyValuePair<Type, object>(typeof(TEntity), new EFRepository<TEntity>(EFContext)));
            }

            return (IRepository<TEntity>)repositories[typeof(TEntity)];
        }

        #region Lambda expression operations
        public IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().Get(filter, orderBy);
        }

        public int Delete<TEntity>(Expression<Func<TEntity, bool>> queryExpression)
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().Delete(queryExpression);
        }

        public int Update<TEntity>(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression)
            where TEntity : class, new()
        {
            return GetRepository<TEntity>().Update(filterExpression, updateExpression);
        }
        #endregion

        #region Batch operations
        public void AddBatch<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : class, new()
        {
            GetRepository<TEntity>().AddBatch(entities);
        }

        public void DeleteBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            GetRepository<TEntity>().DeleteBatch(entities);
        }

        public void UpdateBatch<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : class, new()
        {
            GetRepository<TEntity>().UpdateBatch(entities);
        }
        #endregion

        #region Bulk operations
        public void BulkInsert<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            bulkFlag = true;
            GetRepository<TEntity>().BulkInsert(entities);
        }

        public void BulkDelete<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            bulkFlag = true;
            GetRepository<TEntity>().BulkDelete(entities);
        }

        public void BulkUpdate<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            bulkFlag = true;
            GetRepository<TEntity>().BulkUpdate(entities);
        }
        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (EFContext != null)
                    {
                        EFContext.Dispose();
                        EFContext = null;
                    }

                    repositories.Clear();
                }
            }

            this.disposed = true;
        }
    }
}