using System;
using System.Collections.Generic;
using System.Text;

namespace XY.His.Contract.Message
{    
    [Serializable]
    public class Response
    {
        public Response()
        {
            Status = ResponseStatus.OK;
            Message = string.Empty;
            Result = null;
        }

        public ResponseStatus Status { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }
    }

    public enum ResponseStatus
    {
        OK = 0,
        Error = 1,
    }
}
