using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.str.op.unary
{
	public partial class Concat
	{
		static public LangI Eval(IEnumerable< LangI > x) {

			if (x.Any())
			{
				return new lang.op.binary.Concat.Call(x.First(), Eval(x.Skip(1)));

			}
			else
			{
				return lang.s.White.Singleton;
			}
		
		
		}

		public class Call :nilnul.obj.op.Call_ArgA<nilnul.collection.recur.StrI< LangI>>,LangI
		{

			public Call( nilnul.collection.recur.StrI<LangI> langs  ):base(langs)
			{

			}

			public bool contains(string element)
			{

				Eval(arg).contains(element);

				throw new NotImplementedException();
			}
		}
	}
}
