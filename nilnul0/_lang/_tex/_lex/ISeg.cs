namespace nilnul._lang._lex
{
	/// <summary>
	/// partitioned into segs. each seg is not empty. if two whitespaces are consecutive, in between the whitespace is not a seg. Rather we can tree the two witespace are collasped into one separator.
	/// </summary>
	/// alias:
	///		<see cref="IToken"/>
	interface ISeg { }
}
