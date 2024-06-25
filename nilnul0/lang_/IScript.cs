namespace nilnul.lang_
{
	/// <summary>
	/// <see cref="nilnul.lang.run_.Interpret"/>
	/// </summary>
	/// <remarks>
	/// eg:
	///		sql, where each file is independently correct or not.
	///		javaScript,where each snippet is independent; that is if one throws exception, that one is terminated, but other script would still run.
	///		
	/// </remarks>
	interface IScript:nilnul.ILang { }

}
