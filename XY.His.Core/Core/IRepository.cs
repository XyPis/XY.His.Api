using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Z.EntityFramework.Extensions;

namespace XY.His.Core
{
    internal interface IRepository<T>
        where T : class, new()
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        IQueryable<T> GetAll();

        T GetById(params object[] ids);

        void DeleteById(params object[] ids);

        int DeleteAll();

        void AddBatch(IEnumerable<T> entities);

        void UpdateBatch(IEnumerable<T> entities);

        void DeleteBatch(IEnumerable<T> entities);

        void BulkInsert(IEnumerable<T> entities);

        void BulkDelete(IEnumerable<T> entities);

        void BulkUpdate(IEnumerable<T> entities);

        IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        //int Update(Expression<Func<T, bool>> filterExpression, Expression<Func<T, T>> updateExpression);

        int Delete(Expression<Func<T, bool>> queryExpression);
    }
}
