using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_._join
{
	public class Ret
		:

		regex.op_.binary._call_.ArgArg1
		,
		RegexI


	{
		public Ret(RegexI arg, RegexI arg1) : base(arg, arg1)

		{
		}

		public Predicate<string> pred
		{
			get
			{
				return x =>
				{
					var a = new StringBuilder();
					var b = new StringBuilder(x);
					var b1 = b.ToString();

					do
					{

						if (arg.pred(a.ToString()) && arg.pred(b1))
						{
							return true;
						}
						if (b1.Any())
						{
							var c = b[0];
							b.Remove(0, 1);

							a.Append(c);
							b1 = b.ToString();

						}
						else
						{

							return false;

						}

					} while (true);

				}
				;
			}

		}
	}
}
