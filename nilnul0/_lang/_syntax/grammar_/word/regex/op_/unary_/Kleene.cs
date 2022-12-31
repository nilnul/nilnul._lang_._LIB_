using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary_
{
	/// <summary>
	/// R*, where "R" is a regex, means the Join of {R^0, R^1, ...... }
	/// </summary>
	public class Kleene : op_.UnaryI
	{
		public RegexI op(RegexI par)
		{
			return new _kleene.Ret(par);
			//throw new NotImplementedException();
		}

		static public Kleene Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Kleene>.Instance;
			}
		}

	}
}
