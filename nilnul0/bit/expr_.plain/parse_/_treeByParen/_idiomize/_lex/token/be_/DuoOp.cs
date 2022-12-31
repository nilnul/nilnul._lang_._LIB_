using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize._lex.token.be_

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
