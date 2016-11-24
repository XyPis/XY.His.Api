using System;
using System.Collections.Generic;
using System.Text;

namespace XY.His.Contract.Message
{
    [Serializable]
    public class Request
    {
        public Request(string assemblyName, string className, string methodName)
        {
            this.AssemblyName = assemblyName;
            this.ClassName = className;
            this.MethodName = methodName;
        }

        public Request(string assemblyName, string className, string methodName, object[] inputParam)
        {
            this.AssemblyName = assemblyName;
            this.ClassName = className;
            this.MethodName = methodName;
            this.InputParam = inputParam;
        }

        public string AssemblyName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }   
        public object[] InputParam { get; set; }
    }
}
