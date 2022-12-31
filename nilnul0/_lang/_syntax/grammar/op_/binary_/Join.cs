using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G = nilnul._lang._syntax.GrammarI_contain;

namespace nilnul._lang._syntax.grammar.op_.binary_
{
	
	public partial class Join:BinaryI
	{

		
		public G op(G a, G b)
		{
			return new _join.Ret(a,b);
		}

	}
}
