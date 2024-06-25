using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary_._kleene
{
	public class Ret
		: nilnul.obj.op_.unary._call.ArgA<RegexI>
		,
		RegexI
	{


		public Predicate<string> pred
		{
			get
			{
				return x =>{
					var num = 0;
					var cumulated = binary_.join.cumulator_.Unardable.Singleton.initial;

					while (num <= x.Length)
					{
						if (cumulated.pred(x))
						{
							return true;
						}
						cumulated = binary_.join.cumulator_.Unardable.Singleton.binder.op(cumulated, this.arg);
						num++;
					}
					return false;

				};
			}
		}

		public Ret(RegexI arg) : base(arg)
		{
		}





	}
}
