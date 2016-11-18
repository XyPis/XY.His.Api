using System;
using System.Runtime.Serialization;

namespace XY.His
{
    [Serializable]
    public class ETalkException : ApplicationException, ISerializable
    {
        // Use returnCode to describe the cause of the exception.
        private ReturnType _returnCode;

        // Define a readonly attribute for returnCode.
        public ReturnType ReturnCode
        {
            get { return _returnCode; }
        }

        #region Constructor

        public ETalkException() : base()
        {
        }

        public ETalkException(string message) : base(message)
        {
        }

        public ETalkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ETalkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ETalkException(string message, ReturnType returnCode) : this(message)
        {
            this._returnCode = returnCode;
        }

        public ETalkException(string message, Exception innerException, ReturnType returnCode)
            : this(message, innerException)
        {
            this._returnCode = returnCode;
        }

        #endregion

        #region ISerializable Members

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ReturnCode", ReturnCode);
            base.GetObjectData(info, context);
        }

        #endregion
    }

 
    #region InvokeException

    [Serializable]
    public class InvokeException : ETalkException
    {
        public InvokeException() : base()
        {
        }

        public InvokeException(string message) : base(message)
        {
        }

        public InvokeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvokeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public InvokeException(string message, ReturnType returnCode) : base(message, returnCode)
        {
        }

        public InvokeException(string message, Exception innerException, ReturnType returnCode)
            : base(message, innerException, returnCode)
        {
        }
    }

    #endregion
}