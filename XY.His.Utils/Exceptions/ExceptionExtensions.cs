using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XY.His.Utils.Exceptions
{
    public static class ExceptionExtensions
    {
        public static Exception GetInnerException(this Exception ex)
        {
            if (ex.InnerException == null) return ex;

            return ex.InnerException.GetInnerException();
        }
    }
}
