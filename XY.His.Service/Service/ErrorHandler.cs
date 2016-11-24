using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Web;
using log4net;
using XY.His.Contract.Message;

namespace XY.His.Service
{    
    public class ErrorHandler : IErrorHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void ProvideFault(Exception error, MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {
            error = GetInnerException(error);

            CommonFaultContract cf = new CommonFaultContract()
            {
                ErrCode = 50000,
                Message = error.Message
            };

            FaultException<CommonFaultContract> fex = new FaultException<CommonFaultContract>(cf);
            MessageFault mf = fex.CreateMessageFault();
            fault = System.ServiceModel.Channels.Message.CreateMessage(version, mf, Constants.Action);
        }

        // HandleError. Log an error, then allow the error to be handled as usual.
        // Return true if the error is considered as already handled
        public bool HandleError(Exception error)
        {
            if (error != null)
            {
                Exception innerException = GetInnerException(error);
                Log.Error(innerException);
            }

            return true;
        }

        private Exception GetInnerException(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }

            return ex;
        }
    }
}