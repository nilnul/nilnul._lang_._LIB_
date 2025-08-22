using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.sentence_
{
	/// <summary>
	/// with prefix, it's regarded as a sentence, but the ending ';' is not needed.
	/// eg:
	///		function signature like:
	///			int Main(){}
	///		type signature like:
	///			class A{}
	///	; or with name like in Xml:
	///		{name} ... {/name}
	/// </summary>
	/// <remarks>
	/// eg:
	///		if(true){}
	///	, where "{}" can also be a single primitive sentence.
	/// </remarks>
	internal class PrefixedBlock
	{
	}
}
