using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Runtime.CompilerServices
{
    public interface IBaseAwaiter : ICriticalNotifyCompletion
    {
        bool IsCompleted { get; }
    }
    public interface IAwaiter : IBaseAwaiter
    {
        void GetResult();
    }

    public interface IAwaiter<TResult> : IBaseAwaiter
    {
        TResult GetResult();
    }
}
