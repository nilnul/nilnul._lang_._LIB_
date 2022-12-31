using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_
{

	/// <summary>
	/// 分词.
	/// output a str of term (token), such as word"abc1", punctuations:",".
	/// note, " " as the separator of tokens, would finish its mission and be removed. ";" is preserved as it's used in later phase_.Parser for sentences separation

	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ITokenizer
	{
	}
}
