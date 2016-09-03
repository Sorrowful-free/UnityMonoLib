﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    
	public delegate void Action<in T1, in T2, in T3, in T4, in T5> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8> (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
}
