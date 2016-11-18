using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Transactions;
using log4net;
using Microsoft.Practices.Unity;

namespace XY.His.Core
{
    public class CommandWrapper : ICommandWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool disposed = false;

        public CommandWrapper(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        
        public IUnitOfWork UnitOfWork { get; private set; }

        public void Execute(Action<IUnitOfWork> worker, TransactionOption option = TransactionOption.Context)
        {
            if (worker == null)
            {
                throw new ArgumentException("UnitOfWork can not be null", "worker");
            }                

            Tuple<bool, Exception> result = null;

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.Context:
                        result = this.DoCommand(worker, uow);
                        break;

                    case TransactionOption.Database:
                        result = this.DoDBCommand(worker, uow);
                        break;

                    case TransactionOption.MSDTC:
                        result = this.DoCommandWithMsdtc(worker, uow);
                        break;

                    default:
                        result = this.DoCommand(worker, uow);
                        break;
                }

                if (!result.Item1)
                {
                    Exception ex = result.Item2;

                    Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                    if (ex.InnerException != null)
                    {
                        Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                    }
                    
                    throw ex;
                }
            }
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> worker, TransactionOption option = TransactionOption.Context)
        {
            if (worker == null)
            {
                throw new ArgumentException("UnitOfWork can not be null", "worker");
            }                

            Tuple<bool, Exception, TResult> result = null;

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.Context:
                        result = this.DoCommand(worker, uow);
                        break;

                    case TransactionOption.Database:
                        result = this.DoDBCommand(worker, uow);
                        break;

                    case TransactionOption.MSDTC:
                        result = this.DoCommandWithMsdtc(worker, uow);
                        break;

                    default:
                        result = this.DoCommand(worker, uow);
                        break;
                }        
            }

            if (!result.Item1)
            {
                Exception ex = result.Item2;

                Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                if (ex.InnerException != null)
                {
                    Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                }

                throw ex;
            }

            return result.Item3;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.UnitOfWork.Dispose();
                    this.UnitOfWork = null;
                }
            }

            this.disposed = true;
        }

        private Tuple<bool, Exception> DoCommand(Action<IUnitOfWork> worker, IUnitOfWork uow)
        {            
            Exception exception = null;
            bool doneFlag = false;

            try
            {
                worker(uow);
                uow.SaveChanges();
                doneFlag = true;
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                uow.Dispose();
            }

            return new Tuple<bool, Exception>(doneFlag, exception);
        }

        private Tuple<bool, Exception> DoDBCommand(Action<IUnitOfWork> worker, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;
            using (var tx = db.BeginTransaction())
            {
                var result = this.DoCommand(worker, uow);

                if (result.Item1)
                {
                    tx.Commit();
                }
                else
                {
                    tx.Rollback();
                }

                return result;
            }            
        }

        private Tuple<bool, Exception> DoCommandWithMsdtc(Action<IUnitOfWork> worker, IUnitOfWork uow)
        {
            using (var tx = new TransactionScope())
            {
                var result = this.DoCommand(worker, uow);

                if (result.Item1)
                {
                    tx.Complete();
                }                

                return result;
            }            
        }

        private Tuple<bool, Exception, TResult> DoCommand<TResult>(Func<IUnitOfWork, TResult> worker, IUnitOfWork uow)
        {            
            TResult result = default(TResult);
            Exception exception = null;
            bool doneFlag = false;

            try
            {
                result = worker(uow);
                uow.SaveChanges();
                doneFlag = true;
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                uow.Dispose();
            }

            return new Tuple<bool, Exception, TResult>(doneFlag, exception, result);
        }

        private Tuple<bool, Exception, TResult> DoDBCommand<TResult>(Func<IUnitOfWork, TResult> worker, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;

            using (var tx = db.BeginTransaction())
            {
                var result = this.DoCommand(worker, uow);
                try
                {
                    if (result.Item1)
                    {
                        tx.Commit();
                    }
                    else
                    {
                        tx.Rollback();
                    }
                }
                catch 
                {
                    throw;
                }
                finally
                {
                    tx.Dispose();
                }                                

                return result;
            }
        }

        private Tuple<bool, Exception, TResult> DoCommandWithMsdtc<TResult>(Func<IUnitOfWork, TResult> worker, IUnitOfWork uow)
        { 
            using (var tx = new TransactionScope())
            {
                var result = this.DoCommand(worker, uow);
                if (result.Item1) 
                {
                    tx.Complete();
                }                
                
                return result;
            }
        }
    }
}
