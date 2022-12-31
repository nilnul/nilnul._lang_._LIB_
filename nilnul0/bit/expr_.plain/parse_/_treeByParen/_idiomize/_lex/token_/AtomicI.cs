using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize._lex.token_
{
	public interface AtomicI : SimpleI
	{
	}

	public interface DuoOpI : TokenI { }


	public interface SimpleI : TokenI {

	}
}
