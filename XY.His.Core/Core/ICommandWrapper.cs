using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XY.His.Core
{
    public interface ICommandWrapper : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }

        void Execute(Action<IUnitOfWork> unitOfWork, TransactionOption option = TransactionOption.Context);

        TResult Execute<TResult>(Func<IUnitOfWork, TResult> unitOfWork, TransactionOption option = TransactionOption.Context);   
    }
}
