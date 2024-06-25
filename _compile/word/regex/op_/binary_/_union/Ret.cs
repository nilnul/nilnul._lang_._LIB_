using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_._union
{
	public class Ret
		: nilnul.obj.op_.binary._call.ArgArg1A<RegexI>
		,
		RegexI
	{
		public Ret(RegexI arg, RegexI arg1) : base(arg, arg1)
		{
		}

		public Predicate<string> pred  =>  x=> arg.pred(x) || arg1.pred(x);
				
			

		
	}
}
