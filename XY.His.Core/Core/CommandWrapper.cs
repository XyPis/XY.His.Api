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

        public void Execute(Action<IUnitOfWork> action, TransactionOption option = TransactionOption.Context)
        {
            if (action == null)
            {
                throw new ArgumentException("Action can not be null", "action");
            }                

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.Context:
                        this.DoCommand(action, uow);
                        break;

                    case TransactionOption.Database:
                        this.DoDbCommand(action, uow);
                        break;

                    case TransactionOption.MSDTC:
                        this.DoMsdtcCommand(action, uow);
                        break;

                    default:
                        this.DoCommand(action, uow);
                        break;
                }
            }
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> action, TransactionOption option = TransactionOption.Context)
        {
            TResult result = default(TResult);

            if (action == null)
            {
                throw new ArgumentException("Action can not be null", "action");
            }

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.Context:
                        result = this.DoCommand(action, uow);
                        break;

                    case TransactionOption.Database:
                        result = this.DoDbCommand(action, uow);
                        break;

                    case TransactionOption.MSDTC:
                        result = this.DoMsdtcCommand(action, uow);
                        break;

                    default:
                        result = this.DoCommand(action, uow);
                        break;
                }
            }

            return result;
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

        private void DoCommand(Action<IUnitOfWork> action, IUnitOfWork uow)
        {
            action(uow);
            uow.SaveChanges();
        }

        private void DoDbCommand(Action<IUnitOfWork> action, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;

            using (var tx = db.BeginTransaction())
            {
                try
                {
                    this.DoCommand(action, uow);
                    tx.Commit();
                }
                catch
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                    }

                    throw;
                }
            }
        }

        private void DoMsdtcCommand(Action<IUnitOfWork> action, IUnitOfWork uow)
        {
            using (var tx = new TransactionScope())
            {
                try
                {
                    this.DoCommand(action, uow);
                    tx.Complete();
                }
                catch
                {
                    throw;
                }
            }
        }

        private TResult DoCommand<TResult>(Func<IUnitOfWork, TResult> action, IUnitOfWork uow)
        {
            TResult result = default(TResult);

            try
            {
                result = action(uow);
                uow.SaveChanges();
            }
            catch
            {
                throw;
            }
            
            return result;
        }

        private TResult DoDbCommand<TResult>(Func<IUnitOfWork, TResult> action, IUnitOfWork uow)
        {
            TResult result = default(TResult);

            var db = uow.EFContext.Database;
                         
            using (var tx = db.BeginTransaction())
            {
                try
                {
                    result = this.DoCommand(action, uow);
                    tx.Commit();
                }
                catch
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                    }

                    throw;
                }
            }

            return result;
        }

        private TResult DoMsdtcCommand<TResult>(Func<IUnitOfWork, TResult> action, IUnitOfWork uow)
        {
            TResult result = default(TResult);
            
            using (var tx = new TransactionScope())
            {
                try
                {
                    result = this.DoCommand(action, uow);
                    tx.Complete();
                }
                catch
                {
                    throw;
                }
            }

            return result;
        }
    }
}
