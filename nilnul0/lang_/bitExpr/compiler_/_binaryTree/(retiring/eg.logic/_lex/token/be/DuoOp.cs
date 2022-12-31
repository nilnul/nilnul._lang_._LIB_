using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token.be
{
	public class DuoOp
	{
		static public bool Eval(TokenI token) {
			return token is And
				|| token is Or
				|| token is Le
				|| token is Eq;
		}
	}
}
