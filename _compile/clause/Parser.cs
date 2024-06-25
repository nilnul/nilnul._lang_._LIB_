using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_
{

	/// <summary>
	/// words to(may by way of syntactic well-formed nominal form) semantic tree
	/// output: sentences.
	/// sentence is: for example in C#, braces-enclosed sentence, which is group ,and semicolon-ended sentence, which is primitive.
	///			sentence can recursively contains clauses, which, if not nested, is a sentence by itself.
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		
	///	mneumonics:
	///		parse is "partial", hence context free
	///		parse is a phase.
	///		parse is anto to phrase
	/// </remarks>
	interface IParser
	{
	}
}
