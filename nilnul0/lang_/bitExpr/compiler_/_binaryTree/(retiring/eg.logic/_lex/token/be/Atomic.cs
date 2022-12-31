using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token.be
{
	public class Atomic
	{
		static public bool Eval(TokenI token) {
			return token is Var1
				|| token is Zero
				|| token is One
				;
		}
	}
}
