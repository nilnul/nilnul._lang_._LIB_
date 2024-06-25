namespace nilnul.lang_
{
	/// <summary>
	/// any txt is valid; this is superlang of all other langs;
	/// and also every lang shall also allow comment, embed this lang into that lang. (for infinite set, it's possible to embed a supset into a subset.); 
	/// </summary>
	/// eg:
	///		for json which disallows comment, it's not a good design;
	///		for json which allows comment in the form of c# comment, such as global.json for msbuild.exe, is a better design;
	/// <remarks>
	///eg:
	///		comment, where we can take the full program as comment|opaque, which then can be parsed outside lang knowledge domain by, eg, natural language processing.
	///	this is the most trivia language. the complement of this, another language as simple as this, is <see cref="INone"/>
	///			
	/// </remarks>
	/// alias:
	///		ling
	public interface IAll { }

}
