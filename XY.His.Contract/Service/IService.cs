using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Serialize.Linq.Nodes;

namespace XY.His.Contract.Service
{    
    public interface IService<TDTO> : IServiceBase
        where TDTO : DtoBase, new()
    {        
        TDTO Add(TDTO dto);
        
        Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos);
        
        void Delete(TDTO dto);

        void DeleteById(object key);

        int DeleteAll();

        void Update(TDTO dto);

        TDTO GetById(object key);
       
        IEnumerable<TDTO> GetAll();
        
        int AddBatch(IEnumerable<TDTO> dtos);

        int DeleteBatch(IEnumerable<TDTO> dtos);

        int UpdateBatch(IEnumerable<TDTO> dtos);

        void BulkInsert(IEnumerable<TDTO> dtos);

        void BulkUpdate(IEnumerable<TDTO> dtos);

        void BulkDelete(IEnumerable<TDTO> dtos);
        
        IEnumerable<TDTO> Get(ExpressionNode query);
        
        int Delete(ExpressionNode query);
    }
}
