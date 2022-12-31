using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.arg_
{
	public class AtomX
	{

		static public nilnul.bit.expr_.plain_.AtomicI Create(_idiomize_._alternate.nub_.arg_.AtomI arg)
		{

			if (arg is _idiomize_._alternate.nub_.arg_.Zero)
			{
				return nilnul.bit.expr_.plain_.call_.Nary.CreateNil();
			}
			else if (arg is _idiomize_._alternate.nub_.arg_.One)
			{
				return nilnul.bit.expr_.plain_.call_.Nary.CreateOne();


			}
			else if (arg is _idiomize_._alternate.nub_.arg_.Var)
			{

				return Create(arg as _idiomize_._alternate.nub_.arg_.Var);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}

		static public nilnul.bit.expr_.plain_.AtomicI Create(_idiomize_._alternate.nub_.arg_.Var arg)
		{

			return new nilnul.bit.expr_.plain_.Var(
				nilnul.obj.var.set.NamingContext.Instance.getOrCreateVar<nilnul.bit.Var2>(

					(arg as _idiomize_._alternate.nub_.arg_.Var).token.name1

				)

			);

		}
	}

}

