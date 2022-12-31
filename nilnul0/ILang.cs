namespace nilnul
{
	/// <summary>
	/// with semantic intention, we invented syntax, which defines a collection of txt. Lang is more than a collection of txt.
	/// 
	/// a collection/container of str, or, nilnul.txt.Collection (including Set, but not limited to Set). 'cuz the collection is often infinite, the rules to define the "contain" logic are complex. We here research the rules that are complex engough to be researched.
	/// After a lang is defined, by the above definition, the lang is syntactically defined. We here only deal with syntactic definition. we then can interpret the lang, in the sense of semantics; the semantics of lang is regarded as the extension of lang, not the lang itself's essencial core.
	/// Lang is different from nilnul.txt.Collection in that Lang invovles semantics, or interpretation of every sentence.
	///		also, lang is more than sentence. it delves into sentence for epxression(semantic)-phrase(syntax)/word/char; it can amass sentences into "Block", and a block has context(such as vars, or dictionary of vars), and funcitonBody(contextual var as inputs), function, class, module.
	/// </summary>
	/// <remarks>
	/// this is formal language. for human language <see cref="nilnul.ling"/>
	/// </remarks>
	/// vs:
	///		ling
	///			we start with the simplest language, which is computer language. Human Natural language is more complex than computer language, and thus would be tackled later as ling.
	public interface ILang {

	}

}
