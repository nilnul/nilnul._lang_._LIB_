using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op
{
	/// <summary>
	/// for a call, return LangI if evaled.
	/// </summary>
	public partial interface EvalI
	{
		LangI eval();
	}

}
