using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token.str
{
	public class List:List<TokenI>
	{

		public override string ToString()
		{
			return string.Join(",", this);
		}
	}
}
