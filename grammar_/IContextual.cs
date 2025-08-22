namespace nilnul._lang._syntax.grammar_
{
	/// each variable is in a scope
	/// <summary>
	/// xAy :: xzy
	///		,where A is nonterminal, x,y,z is string of terminal and|or nontermial.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		scoped
	///		contextual
	///	vs:
	///		closure, which is execution context, while this is lexical context;
	interface IContextual { }
}
