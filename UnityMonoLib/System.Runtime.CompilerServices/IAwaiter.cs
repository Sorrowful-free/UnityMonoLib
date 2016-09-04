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
    interface IAwaiter : IBaseAwaiter
    {
        void GetResult();
    }

    interface IIAwaiter<TResult> : IBaseAwaiter
    {
        TResult GetResult();
    }
}
