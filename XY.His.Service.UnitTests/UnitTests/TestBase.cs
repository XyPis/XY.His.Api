using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;

namespace XY.His.Service.UnitTests
{
    public class TestBase : IDisposable
    {
        public TestBase()
        {
            ServiceProxy.Host = "localhost";
            ServiceProxy.Port = 8088;
        }

        private bool disposed = false;

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
