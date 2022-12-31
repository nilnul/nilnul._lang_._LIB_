using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.set.op
{
	public partial class Union
	{
		static public LangI Eval(HashSet<LangI> langs) {
			return lang.str.op.unary.Union.Eval(langs);
		}
	}
}
