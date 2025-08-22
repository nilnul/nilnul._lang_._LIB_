using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar.symbol.be_.regulable_
{
	/// <summary>
	///The system {b → a, b → c, c → b, c → d} is an example of a weakly normalizing but not strongly normalizing system.
	///a and d are normal forms,
	///
	///and b and c can be reduced to a or d, but there also exists the infinite reduction b → c → b → c → ... , which means that neither b nor c is strongly normalizing.
	/// 
	/// </summary>
    class IUnStrongly
    {
    }
}
