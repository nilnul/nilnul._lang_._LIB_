using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic.parser
{
	/// <summary>
	/// must decide that only one rule is valid.
	/// if no rule is valid, error. If more than one  rule is valid, error (ambigurous).
	/// 
	/// So this will reduce error when the production rule is ambiguous.
	/// 
	/// If we gurantee that the rule is not ambiguous, we should abandon this parser in that we have better option.
	/// 
	/// </summary>
	public class TryEveryRule
	{


	}
}
