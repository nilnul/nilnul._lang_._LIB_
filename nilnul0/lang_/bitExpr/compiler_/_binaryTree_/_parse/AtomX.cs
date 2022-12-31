using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse
{
	public class AtomX
	{

		static public nilnul.bit.expr.vow_.atomic.Ed Create(_tokens2WellCombined._wellCombined._alternate.nub_.arg_.AtomI arg)
		{

			if (arg is _tokens2WellCombined._wellCombined._alternate.nub_.arg_.Zero)
			{
				return nilnul.bit.expr_.call_.No.CreateNil();
			}
			else if (arg is _tokens2WellCombined._wellCombined._alternate.nub_.arg_.One)
			{
				return nilnul.bit.expr_.call_.No.CreateOne();


			}
			else if (arg is _tokens2WellCombined._wellCombined._alternate.nub_.arg_.Var)
			{

				return Create(arg as _tokens2WellCombined._wellCombined._alternate.nub_.arg_.Var);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}

		static public nilnul.bit.expr.vow_.atomic.Ed Create(_tokens2WellCombined._wellCombined._alternate.nub_.arg_.Var arg)
		{

			return new nilnul.bit.expr_.VarAsExpr(
				nilnul.obj.var.set.NamingContext.Instance.getOrCreateVar<nilnul.bit.Var2>(

					(arg as _tokens2WellCombined._wellCombined._alternate.nub_.arg_.Var).token.name1

				)

			);

		}
	}

}

