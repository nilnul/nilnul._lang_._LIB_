using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._syntax.grammar_._preproc.comment_
{
	enum Adfix
	{
		/// usually a single line comment is used to follow text till the line, hence it's naturally used as a suffix comment;
		/// <summary>
		/// 
		/// eg:
		///		//this comment is for the previous lines; note we have no extra slashes;
		///	
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		Suffix
			,
		/// in comparision <see cref="Suffix"/>, we have to explicitly add extra puncs to make this different from default <see cref="Suffix"/>;
		/// <summary>
		/// eg:
		///		/// this comment is for the followed. note we have tripple slashes;
		/// </summary>
		Prefix
			,
		/// <summary>
		/// eg:
		///		asbac/*this comment is for what's wrapping around this comment*/ asdfa
		/// </summary>
		Infix
	}
}
