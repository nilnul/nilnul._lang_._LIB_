using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Str = nilnul.collection.recur.StrI<nilnul.character.LangI>;

namespace nilnul.character.lang.str.op.unary
{
	public partial class Union
	{
		static public LangI Eval(IEnumerable< LangI > x) {

			if (x.Any())
			{
				return new lang.op.binary.Union.Call(x.First(), Eval(x.Skip(1)));

			}
			else
			{
				return lang.s.Empty.Singleton;
			}
		
		
		}

		public class Call :nilnul.obj.op.Call_ArgA<nilnul.collection.recur.StrI< LangI>>,LangI
		{
			public Call(Str langs):base(langs)
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
