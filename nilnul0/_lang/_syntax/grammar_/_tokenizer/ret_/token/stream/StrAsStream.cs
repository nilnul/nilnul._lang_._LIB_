using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_._tokenizer.ret_.token
{
	public class StrAsStream<T>
		:
		nilnul.obj.stream.StrAsStream<T>
		,
		StreamI<T>
		where T : class, IToken
	{

		public StrAsStream(IEnumerable<T> str):base(str)
		{

		}
	}


	public class StrAsStream_TokenI:StrAsStream<IToken>
	{
		public StrAsStream_TokenI(IEnumerable<IToken> str):base(str)
		{

		}
	}

	//public class StrAsStream
	//	:StreamI,
	//	nilnul._stream.NextI<TokenI>
	//{

	//	//private IEnumerable<TokenI> _tokens;

	//	//public IEnumerable<TokenI> tokens
	//	//{
	//	//	get { return _tokens; }
	//	//	set { _tokens = value; }
	//	//}

	//	private IEnumerator<TokenI> _enumerator;

	//	public IEnumerator<TokenI> enumerator
	//	{
	//		get { return _enumerator; }
	//		set { _enumerator = value; }
	//	}

	//	public StrAsStream(IEnumerable<TokenI> tokens)
	//	{
	//		_enumerator = tokens.GetEnumerator();

	//	}


	//	public TokenI next()
	//	{
	//		return _enumerator.MoveNext() ? _enumerator.Current : null;

	//		throw new NotImplementedException();
	//	}
	//}
}
