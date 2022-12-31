using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._build
{
	public class AtomX
	{

		static public nilnul.bit.expr.AtomI Create(_walk.nub.arg.AtomI arg)
		{

			if (arg is _walk.nub.arg.Zero)
			{
				return nilnul.bit.expr.no.Call.CreateNil();
			}
			else if (arg is _walk.nub.arg.One)
			{
				return nilnul.bit.expr.no.Call.CreateOne();


			}
			else if (arg is _walk.nub.arg.Var)
			{

				return Create(arg as _walk.nub.arg.Var);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}

		static public nilnul.bit.expr.AtomI Create(_walk.nub.arg.Var arg)
		{



			return new nilnul.bit.expr.VarAsExpr(
				nilnul.var.set.NamingContext_ofVarI.Instance.getOrCreateVar<nilnul.bit.Var2>(

					(arg as _walk.nub.arg.Var).token.name1

				)

			);

		}
	}

}

