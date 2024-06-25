using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_._tokenizer.ret_.token
{

	public interface StreamI_tokenI : StreamI<IToken> { }
	public interface StreamI<T> : nilnul._stream.NextI<T>,StreamI
		where T :IToken
	{ }


	public interface StreamI
	{
	}
}
