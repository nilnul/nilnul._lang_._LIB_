using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_._tokenizer
{
	/// <summary>
	/// unlike punc, which is a token, whitespace is not token,but a separator for tokens.
	/// So punc might appear in a token. To make sure a punc is also a token border, not part of a token, we can append a whitespace to it.
	/// eg:
	///		This shoe is Ann's. Note the space after the dot.
	///		Also note the linebreak after the "." at the end of last line.
	/// </summary>
	class Whitespace
	{
	}
}
