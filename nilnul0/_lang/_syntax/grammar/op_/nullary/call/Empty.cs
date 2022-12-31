using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op.nullary.call
{
	public partial class Empty
		:CallI
	{

		public LangI eval()
		{
			return lang.s.Empty.Singleton;

			throw new NotImplementedException();
		}
	}
}
