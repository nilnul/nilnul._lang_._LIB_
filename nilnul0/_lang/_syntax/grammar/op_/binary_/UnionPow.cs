using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.character.lang.op.binary
{
	
	public partial class UnionPow
	{
		static public LangI Eval(  nilnul.num.natural.Natural_bigInteger a, LangI b)
		{
			if (a==0)
			{
				return lang.s.Empty.Singleton;
				
			}
			return b;

			throw new NotImplementedException();
		}



		public class Call : nilnul.obj.op.Call_ArgArg1A<nilnul.num.natural.Natural_bigInteger, LangI>
			,
			nilnul.character.LangI
		{

			public Call(N x, LangI y)
				: base(x, y)
			{

			}


			public bool contains(string element)
			{
				return Eval(arg,arg1).contains(element);

				throw new NotImplementedException();
			}
		}

	}
}
