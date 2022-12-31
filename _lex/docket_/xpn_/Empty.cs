using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._lex.docket_.xpn_
{
	/// <summary>
	/// unlike <see cref="_tex.symbol_.IEmpty"/>, it makes nonsense for <see cref="docket_"/> to be empty
	/// </summary>

	[Serializable]
	public class EmptyException : Exception
	{
		public EmptyException() { }
		public EmptyException(string message) : base(message) { }
		public EmptyException(string message, Exception inner) : base(message, inner) { }
		protected EmptyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
