using System.Collections.Generic;

namespace System.Runtime.ExceptionServices
{
	public sealed class ExceptionDispatchInfo
	{
        public static readonly List<Exception> ExceptionsList = new List<Exception>();
		readonly Exception _exception;
		
		private ExceptionDispatchInfo (Exception source)
		{
			_exception = source;
		}

		public Exception SourceException { get { return _exception; } }

		public static ExceptionDispatchInfo Capture (Exception source)
		{
			if (source == null)
				throw new ArgumentNullException ("source");

			return new ExceptionDispatchInfo (source);
		}

		public void Throw ()
		{
            throw new Exception(_exception.Message, _exception); ;			
        }
	}
}