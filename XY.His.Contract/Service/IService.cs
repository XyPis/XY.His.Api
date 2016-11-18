using System;
using System.Collections.Generic;
using System.Text;

namespace XY.His.Contract.Service
{    
    public interface IService<TDTO> : IServiceBase
        where TDTO : DtoBase, new()
    {        
        TDTO Add(TDTO dto);
        
        //Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos);
        
        void Delete(TDTO dto);

        void DeleteById(object key);

        int DeleteAll();

        void Update(TDTO dto);

        TDTO GetById(object key);
       
        IEnumerable<TDTO> GetAll();
        
        int AddBatch(IEnumerable<TDTO> dtos);

        int DeleteBatch(IEnumerable<TDTO> dtos);

        int UpdateBatch(IEnumerable<TDTO> dtos);

        //void BulkInsert(IEnumerable<TDTO> dtos);

        //void BulkUpdate(IEnumerable<TDTO> dtos);

        //void BulkDelete(IEnumerable<TDTO> dtos);
        
        //Lambda expression support
        //[OperationContract]
        //IEnumerable<TDTO> Get(Expression<Func<TDTO, bool>> queryExpression);

        //int Update(Expression<Func<TDTO, bool>> filterExpression, Expression<Func<TDTO, TDTO>> updateExpression);

        //[OperationContract]
        //int Delete(Expression<Func<TDTO, bool>> queryExpression);
    }
}
