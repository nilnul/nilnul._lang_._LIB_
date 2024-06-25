using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._syntax.grammar_._preproc.comment_
{
	enum Adfix
	{
		/// usually a single line comment is used to follow text till the line, and we might accidently or soft wrap it to another line, hence it's naturally used as a suffix comment, when it's in a beneath line;
		/// <summary>
		/// 
		/// eg:
		///		//this comment is for the previous lines; note we have no extra slashes;
		///	
		/// </summary>
		/// <remarks>
		///  // <-
		///		is more obvious;
		/// </remarks>
		/// alias:
		///		remark
		///			is the comment for what comes before
		///		annotation
		///		memo
		Suffix
			,
		/// in comparision <see cref="Suffix"/>, we have to explicitly add extra puncs to make this different from default <see cref="Suffix"/>;
		/// <summary>
		/// eg:
		///		/// this comment is for the followed. note we have tripple slashes;
		///		//: note colon is used here to mean this is to label what's followed; we may replace ':' with another conspicuous special char such as slash;
		///		/// for ".bat" we can use "rem :", where a space is required before ':';
		///		
		/// </summary>
		/// // -> is explicit;
		///  alias:
		///		memo
		///		notation
		///		note
		Prefix
			,
		/// <summary>
		/// eg:
		///		asbac/*this comment is for what's wrapping around this comment*/ asdfa
		/// </summary>
		Infix
	}
}
