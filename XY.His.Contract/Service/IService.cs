using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using Serialize.Linq.Nodes;

namespace XY.His.Contract.Service
{    
    [ServiceContract]
    public interface IService<TDTO> : IServiceBase
        where TDTO : DtoBase, new()
    {        
        [OperationContract]
        TDTO Add(TDTO dto);

        [OperationContract]
        Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        void Delete(TDTO dto);

        [OperationContract]
        void DeleteById(object key);

        [OperationContract]
        int DeleteAll();

        [OperationContract]
        void Update(TDTO dto);

        [OperationContract]
        TDTO GetById(object key);

        [OperationContract]
        IEnumerable<TDTO> GetAll();

        [OperationContract]
        int AddBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int DeleteBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int UpdateBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        void BulkInsert(IEnumerable<TDTO> dtos);

        [OperationContract]
        void BulkUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        void BulkDelete(IEnumerable<TDTO> dtos);

        [OperationContract]
        IEnumerable<TDTO> GetBy(ExpressionNode query);

        [OperationContract]
        int DeleteBy(ExpressionNode query);
    }
}
