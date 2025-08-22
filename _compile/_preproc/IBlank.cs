using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._compile._preproc
{
	/// <summary>
	/// trimmed.
	/// the inner consecutive blanks are collapsed.
	/// the inner single blank is preserved; eg:
	///		a/*comment*/b
	///		, is not ab, unable to be an identifier
	///		;
	/// </summary>
	internal class IBlank
	{
	}
}
