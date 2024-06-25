namespace nilnul.lang_
{
	/// <summary>
	/// eg:
	///		abc(def(gh)
	///	where "()" encloses comment, comment can be nested recursively, and borderly(begining or trailing) parenthesis can be omitted.
	/// </summary>
	/// <remarks>
	/// this will be implemented in detail in a later project named: nilnul.lang_._cot_;
	/// this is the simplest language involving "()" to establish a tree out of linear txt, a character str. before this, abc123 for example, is regarded as not lang, but a lex:<see cref="nilnul.obj.ILex"/>;
	///
	/// This is a dual covering all:
	///		comment, noncomment.
	///		in otherwords, lang and nonlang;
	/// </remarks>
	/// vs:
	///		nilnul.lang_._cot_ that is nestable, whileas this is not.
	public interface ICommentedTxt { }

}
