using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using L = nilnul._lang._syntax.GrammarI_contain;

namespace nilnul._lang._syntax.grammar.op_.binary_._join
{



	public class Ret : _lang._syntax.grammar.op_.binary._call_.ArgArg1_grammarContain
		, nilnul._lang._syntax.GrammarI_contain
	{

		public Ret(L x, L y) : base(x, y)
		{

		}


		public bool contains(string element)
		{
			var len = element.Length;
			for (int i = 0; i < len; i++)
			{
				var pre = element.Substring(0, i);
				var pos = element.Substring(i, len - i);
				if (arg.contains(pre) & arg1.contains(pos))
				{
					return true;

				}

			}
			return false;


			throw new NotImplementedException();
		}
	}
}
