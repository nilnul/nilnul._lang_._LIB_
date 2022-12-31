using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token
{
	public class Stream: nilnul._lang._syntax.grammar_._tokenizer.ret_.token.StrAsStream<eg.logic._lex.TokenI>
	{
		public Stream(IEnumerable<eg.logic._lex.TokenI> str):base(str)
		{

		}
	}
}
