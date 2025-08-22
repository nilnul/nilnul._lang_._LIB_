using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar.symbol.deduce.relay_
{
	/// <summary>
	/// one is deduced to itself or another previous one.
	/// </summary>
	///	alias:
	///		terminating or noetherian
	///		canonical,
	///		convergent

    public interface IFinite
		:IRelay
    {
    }
}
