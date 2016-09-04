using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace UnityMonoLib.System.Runtime.CompilerServices
{
    public interface IBaseAwaiter : ICriticalNotifyCompletion
    {
        bool IsCompleted { get; }
    }
    public interface IAwaiter : IBaseAwaiter
    {
        void GetResult();
    }

    public interface IIAwaiter<TResult> : IBaseAwaiter
    {
        TResult GetResult();
    }
}
