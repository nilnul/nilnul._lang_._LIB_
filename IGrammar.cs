namespace nilnul.lang
{
	///		/// grammar refers to the concrete syntax of a language, a set of rules often expressed as BFN or EBNF rules that describe what is a valid program in term of shape.
	/// 
	/// vs:
	///		<see cref="nilnul.txt.ILex"/>, which is linear, whileas this is a tree or <see cref="nilnul.txt.lex.ITex"/>
	///	词有词法，句有句法，文有文法。文，如作文，常为语言各层级结构中的最主要层级；比如，Xml Document, C Program, 
	///<summary>
	///		语法 grammar
	///			, 言法 is not a common word.
	///			, but in 中文，we use 文； in 英语，日本语，we use 语。
	///			，包括
	///				copora|context
	///				,
	///				章法|文法|structure|composition(to be composed|compiled)grammar（比如xml|html document, css style sheet, c# type ）
	///				、句法（syntax)
	///				、词法（Lexicology,morphology on morphemes, lexicon, glossary)。
	/// </summary>
	/// <remarks>
	/// A broad term that includes syntax, morphology, and other areas of study. Grammar is both prescriptive and descriptive, meaning it tells how to formally use a language and how its natural speakers and writers use it informally.
	/// </remarks>
	/// <see cref="lang._tier.IGrammar"/>
	interface IGrammar { }
}
