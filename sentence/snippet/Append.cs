using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.lang.sentence.snippet
{
	/// <summary>
	/// per <see cref="lang._sentence.clauses._TxtenX"/>, the last clause is not terminated by ';';
	/// hence, when appending, a ';' might be needed in advance;
	/// </summary>
	internal class _AppendX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="xec">
		/// <see cref="nilnul.xml.el.content"/>
		/// </param>
		/// <param name="newParagraph"></param>
		/// <returns></returns>
		static public string _Append_0snippets(string xec, string newParagraph) {
			return xec +
				(Regex.IsMatch(xec, @"(;|}|\A\s*)\z") ? "" : ";")
				+
				newParagraph
			;
		}
	}
}
