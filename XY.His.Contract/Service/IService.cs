using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using Serialize.Linq.Nodes;
using XY.His.Contract.Message;

namespace XY.His.Contract.Service
{   
    [ServiceContract]
    public interface IService<TDTO> : IServiceBase
        where TDTO : DtoBase, new()
    {
        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        TDTO Add(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void Delete(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void DeleteById(object key);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        int DeleteAll();

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void Update(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        TDTO GetById(object key);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        IEnumerable<TDTO> GetAll();

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        int AddBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        int DeleteBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        int UpdateBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void BulkInsert(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void BulkUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        void BulkDelete(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        IEnumerable<TDTO> GetBy(ExpressionNode query);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract))]
        int DeleteBy(ExpressionNode query);
    }
}
