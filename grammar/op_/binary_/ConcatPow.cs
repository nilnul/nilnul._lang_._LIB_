using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.character.lang.op.binary
{

	public partial class ConcatPow
	{

		static public LangI Eval(N index, LangI a)
		{


			throw new NotImplementedException();
		}

		public class Call :
			nilnul.obj.op.Call_ArgArg1A<N, LangI>
			,
			nilnul.character.LangI
		{

			public Call(N x, LangI y)
				: base(x, y)
			{


			}


			public bool contains(string element)
			{

				return new nilnul.character.lang.str.op.unary.Concat.Call(

nilnul.collection.recur.Repeat<LangI>.CallTheMethod(arg, arg1)



					).contains(element);

				throw new NotImplementedException();
			}
		}
	}
}
