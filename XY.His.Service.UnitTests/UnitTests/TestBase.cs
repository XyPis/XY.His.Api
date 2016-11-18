using System;
using Xunit;
using XY.His.Contract.Message;

namespace XY.His.Service.UnitTests
{
    public class TestBase : IDisposable
    {
        private bool disposed = false;

        public TestBase()
        {
            AssemblyName = "XY.His.Service";
        }

        public static string AssemblyName { get; set; }

        public static string ClassName { get; set; }

        public static string MethodName { get; set; }

        public static object[] InputParam { get; set; }

        protected Request BuildRequest()
        {
            return new Request()
            {
                AssemblyName = AssemblyName,
                ClassName = ClassName,
                MethodName = MethodName,
                InputParam = InputParam
            };
        }

        protected Request BuildRequest(string methodName, object[] inputParam)
        {
            MethodName = methodName;
            InputParam = inputParam;

            return new Request()
            {
                AssemblyName = AssemblyName,
                ClassName = ClassName,
                MethodName = MethodName,
                InputParam = InputParam
            };
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {                   
                }
            }

            this.disposed = true;
        }
    }
}
