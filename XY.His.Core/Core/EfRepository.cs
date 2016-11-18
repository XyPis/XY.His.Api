using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using EntityFramework.Extensions;
using log4net;
using Z.EntityFramework.Extensions;

namespace XY.His.Core
{
    internal class EFRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {                
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public EFRepository(DbContext context)
        {
            context.Database.CommandTimeout = 600000;

            ////Log.DebugFormat("Database CommandTimeout: {0} ms", efContext.Database.CommandTimeout);

            this.EFSet = context.Set<TEntity>();
            this.EFContext = context;
        }

        private DbSet<TEntity> EFSet { get; set; }         

        private DbContext EFContext { get; set; }        

        public virtual void Add(TEntity entity)
        {
            this.EFSet.Add(entity);
        }        

        public virtual void Delete(TEntity entity)
        {
            if (this.EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }

            this.EFSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (this.EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }
            else
            {
                this.EFContext.Entry<TEntity>(entity).CurrentValues.SetValues(entity);
            }

            this.EFContext.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public virtual TEntity GetById(params object[] ids)
        {
            return this.EFSet.Find(ids);
        }

        public virtual IQueryable<TEntity> Get()
        {
            return this.EFSet;
        }

        public virtual void DeleteById(params object[] ids)
        {
            this.Delete(this.GetById(ids));
        }

        public virtual int DeleteAll()
        {
            return this.EFSet.Delete();
        }

        #region Lambda Expression Operations
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = this.EFSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public virtual List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = this.EFSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual int Update(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression)
        {
            return this.EFSet.Where(filterExpression).Update(updateExpression);
        }

        public virtual int Delete(Expression<Func<TEntity, bool>> queryExpression)
        {
            return this.EFSet.Where(queryExpression).Delete();
        }
        #endregion

        #region Batch Operations
        public virtual void AddBatch(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(entity =>
            {            
                this.Add(entity);
            });
        }

        public virtual void DeleteBatch(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(entity =>
            {
                this.Delete(entity);
            });
        }

        public virtual void UpdateBatch(IEnumerable<TEntity> entities) 
        {
            entities.ToList().ForEach(entity =>
            {            
                this.Update(entity);
            });
        }        
        #endregion        

        #region Bulk Operations
        public virtual void BulkInsert(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkInsert(entities);
        }

        public virtual void BulkDelete(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkDelete(entities);
        }

        public virtual void BulkUpdate(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkUpdate(entities);
        }
        #endregion
    }
}
