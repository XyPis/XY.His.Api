using System;
using System.Collections.Generic;
using System.Text;

namespace XY.His.Contract.Message
{
    [Serializable]
    public class Request
    {       
        public Request()
        {
        }

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

        /// <summary>
        /// 程序集名称
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 方法名
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// 输入参数
        /// </summary>
        public object[] InputParam { get; set; }

    }
}
