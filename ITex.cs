namespace nilnul.lang
{
	/// <summary>
	/// from lex to tex;
	/// for a tree structured expr based on lex that generates word;
	/// </summary>
	/// <see cref="_lang.ITex"/>
	public interface ITex
		:nilnul.obj.ITo<
			nilnul.obj.IStr<_lex.IDocket>
			,
			nilnul.obj.IStr<_tex.ISymbol>
		>
	{ }


}
