using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_;


namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token.be_
{
	public class Atomic
	{
		static public bool Eval(TokenI token) {
			return token is nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_.Var1
				|| token is Zero
				|| token is One
				;
		}
	}
}
