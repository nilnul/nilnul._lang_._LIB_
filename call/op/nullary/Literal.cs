using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.call.op.nullary
{
	public partial class Literal:CallI
	{
		private LangI _val;

		public LangI val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public Literal(LangI lang)
		{
			_val = lang;

		}


	}
}
