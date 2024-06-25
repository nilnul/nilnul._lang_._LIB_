namespace nilnul.lang
{
	/// <summary>
	/// from chars to a linear string of word0puncS. note: word0punc, unlike <see cref="_tex.ISymbol"/>, cannot be 0length.
	/// </summary>
	/// <remarks>
	/// lex is tacklable by RegExp in nilnul.txt;
	/// the result is a linear structure: a str of tokens; on the other hand:
	///		the result of lang parser is a nonlinear structure such as a tree from parenthesized expression : a(b+1).
	/// </remarks>
	/// vs:
	///		<see cref="nilnul.ILang"/>
	///		<see cref="_lang._tex.ILex"/>
	 interface ILex { }
}
