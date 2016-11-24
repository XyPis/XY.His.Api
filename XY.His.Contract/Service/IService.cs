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
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        TDTO Add(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void Delete(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void DeleteById(object key);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        int DeleteAll();

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void Update(TDTO dto);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        TDTO GetById(object key);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        IEnumerable<TDTO> GetAll();

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        int AddBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        int DeleteBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        int UpdateBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void BulkInsert(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void BulkUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        void BulkDelete(IEnumerable<TDTO> dtos);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        IEnumerable<TDTO> GetBy(ExpressionNode query);

        [OperationContract]
        [FaultContract(typeof(CommonFaultContract), Action = Constants.Action)]
        int DeleteBy(ExpressionNode query);
    }
}
