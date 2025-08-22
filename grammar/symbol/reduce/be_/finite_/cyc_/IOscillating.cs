using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar.symbol.reduce.be_.finite_.cyc_
{
	/// <summary>
	/// eg:
	///		r(x,y) → r(y,x)
	///	, thus:
	///		r(4,2) → r(2,4) → r(4,2) → r(2,4) → ...
	/// </summary>
	/// <remarks>
	/// if commutivity is added, then the system is strongly normalizing and confluent
	/// </remarks>
	class IOscillating
    {
    }
}
