using System;
using System.Runtime.Serialization;

namespace nilnul.bit.expr_.plain.parse_
{
	public partial class TreeByParen
	{
		[Serializable]
		private class ParseException : Exception
		{
			public ParseException()
			{
			}

			public ParseException(string message) : base(message)
			{
			}

			public ParseException(string message, Exception innerException) : base(message, innerException)
			{
			}

			protected ParseException(SerializationInfo info, StreamingContext context) : base(info, context)
			{
			}
		}
	}
}

