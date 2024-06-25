using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_
{
	/// <summary>
	/// the output is chars. the input is chars. This is the second stage of synatx grammars after preprocessing.
	/// </summary>
	/// <remarks>
	/// Even both output and input are chars, the process involves higher construct such as idioms/terms in that:
	///		1) escape sequence is replaced with char
	///			note: the escape sequence's context/location is important. For example, when in string literal, the escape sequence might be interpreted differently. So to differentiate this difference, we may need to parse the construct of string literal. And the output may be chars plus some extra information about string literal such that the parsing effort is not wasted.
	///				or the escape sequence is regarded the same everywhere?
	///		2) comment is removed and replaced with whitespace (0-width maybe)
	///	So you can see in both cases we do some replacing with char
	/// nomenclature:
	///	 aliase:
	///		charwise
	/// </remarks>
	/// <see cref="nameof(Scanner)"/>
	/// 	/// aka: scanner

	public interface IScanner
	{
	}
}
