using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex
{
	public interface TokenI : nilnul._lang._syntax.grammar_._tokenizer.ret_.IToken {

	}
	[Obsolete("TokenI. Symbol is for parser")]
	public class Symbol:TokenI
	{
	}

	
	


}
