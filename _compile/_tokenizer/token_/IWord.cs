using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_._tokenizer.token_
{
	/// <summary>
	/// for a txt str: "abc def"
	///		we have three tokens:
	///			"
	///			abc edf
	///			"
	///	So this is not a lexing process,as in lexer, we further recursively compose idioms from tokens, and compose idioms from idioms. 
	/// </summary>
	class IWord
	{
	}
}
