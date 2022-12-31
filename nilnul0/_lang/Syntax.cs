using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang
{
	/// <summary>
	/// what defines the "bool contain(string sentence)" of the "nilnul.txt.Collection" for the language.
	/// syntax is a collection of hierahchial grammars.There are many grammars for a language. for example, we have syntax for an identifier, another syntax for an expression, and syntax for sentence, and syntax for block, and syntax for function, class, module, sln. Often, for the subsequent ones, such as "sln", we often use HumanLang/Graph/Eg, other than production rules, to define.
	///		or prj/sln can be considered to be an application of lang, not the lang itself. for example, we can use c# to create console or web prj, and we can use JS to create a desktop prj(which is structured to be runnable in a desktop environment). So the structure is not the lang, but subject to what proj we want to construct, and we can find new (not defined in the lang) application scenario for a lang.
	/// </summary>
	/// <remarks>
	/// semantics, not dealt with here, is how we later interpret the composed sentences(often more than one sentence.)
	/// vs:
	///		grammar:
	///			syntax may use predicate the body of which is complex to the extent of a grammar production rules.
	/// </remarks>
	public interface ISyntax
	{
		/// syntax is more than production rules. some logic can not or is difficult to be expressed by production rules.

	}
}
