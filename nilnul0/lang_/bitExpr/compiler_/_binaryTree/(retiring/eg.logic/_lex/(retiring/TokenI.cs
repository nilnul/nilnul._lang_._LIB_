using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex
{


	[Obsolete("Var1")]
	public class Var:Symbol
	{


		public string name = "";

		public void append(char x) {
			name = name + x;
		}

		public void _append(char? _notNull) {
			append(_notNull.Value);
		}

		public override string ToString()
		{
			return name;
		}

	}

	


}
