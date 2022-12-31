using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_
{
	public interface AtomicI : SimpleI
	{
	}

	public interface DuoOpI : TokenI { }

	public interface SimpleI : TokenI {

	}
}
