using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_
{
	/// <summary>
	/// lang without var is a trivia lang, as without var, you will not have loop (loop is based on fork, which is one more step further based on var).
	/// Per logic such as Godel, trivia lang is not strong enough.
	/// But triva lang is still finding its use in some Lexeme parser. For example, Lexer(parsing and phrasing of an Identifier) is such a trivia lang.
	/// eg:
	///		HTML and CSS is triva
	/// </summary>
	class Trivia
	{
	}
}
