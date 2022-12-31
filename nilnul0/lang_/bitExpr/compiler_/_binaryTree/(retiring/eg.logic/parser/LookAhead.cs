using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic.parser
{
	/// <summary>
	/// if we look ahead indefinitly, we may end up:
	/// 1) no rule is applicable
	/// 2) more rules are applicable.
	/// 
	/// If we can guranteee that the production is ambiguous, we then must be able to determine it with constant (given finite) number of look aheads.
	/// 
	/// So don't use this parser for unambiguous production; we have better option: LA(n)
	/// </summary>
	public class LookAhead
	{




	}
}
