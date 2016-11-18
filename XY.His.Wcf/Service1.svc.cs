using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using XY.His.Common;

namespace XY.His.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Response Invoke(string assemblyName, string className, string methodName, params byte[] inputParam)
        {
            Response response = new Response();

            try
            {
                object[] args = Serializer.DeserializeBinary(inputParam);

                object result = InvokeHelper.InvokeMethod(assemblyName, className, methodName, args);

                result = Serializer.SerializeBinary(new object[] { result });

                response.Result = result;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = ResponseStatus.Error;
                response.Result = null;
            }

            return response;
        }
    }
}
