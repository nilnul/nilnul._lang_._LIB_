using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token.str_
{
	public class List:List<TokenI>
	{

		public override string ToString()
		{
			return string.Join(",", this);
		}
	}
}
