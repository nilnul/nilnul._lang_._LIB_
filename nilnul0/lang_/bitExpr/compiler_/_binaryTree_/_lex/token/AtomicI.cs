using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token
{
	public interface AtomicI : SimpleI
	{
	}

	public interface DuoOpI : TokenI { }

	public interface SimpleI : TokenI { }
}
