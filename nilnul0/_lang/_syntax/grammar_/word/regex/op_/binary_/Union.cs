using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_
{
	public class Union : BinaryI
	{
		public RegexI op(RegexI par, RegexI par1)
		{
			return new _union.Ret(par,par1) ;
		}

		static public Union Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Union>.Instance;
			}
		}

	}
}
