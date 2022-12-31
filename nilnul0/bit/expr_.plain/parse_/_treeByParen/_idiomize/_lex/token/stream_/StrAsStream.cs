using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize._lex.token.stream_
{
	public class FroStr:nilnul._lang._syntax.grammar_._tokenizer.ret_.token.StrAsStream<_lex.TokenI>
	{
		public FroStr(IEnumerable<_lex.TokenI> str):base(str)
		{

		}
	}
}
