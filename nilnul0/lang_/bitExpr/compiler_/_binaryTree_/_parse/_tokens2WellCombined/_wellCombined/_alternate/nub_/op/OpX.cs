using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.op
{
	public class OpX
	{
		static public nilnul.bit.CombineI GetBitOp(
			nub_.OpI op	
		) {

			if (op is nub_.op_.And)
			{
				return  nilnul.bit.combine_.And.Instance;
			}
			else if (op is nub_.op_.Or)
			{
				return  nilnul.bit.combine_.Or.Singleton;
			}

			else if (op is nub_.op_.IfThen)
			{
				return  nilnul.bit.combine_.Le.Singleton;
			}

			else if (op is nub_.op_.Iif)
			{
				return  nilnul.bit.combine_.Eq.Singleton;
			}

			else 
			{
				throw new UnexpectedTypeException();
			}

		}


		static public OpI Token2Formula(_lex.token_.DuoOpI token)
		{
			if (token is _lex.token_.And)
			{
				return new nub_.op_.And();
			}
			else if (token is _lex.token_.Or)
			{
				return new nub_.op_.Or();
			}
			else if (token is _lex.token_.Eq)
			{
				return new nub_.op_.Iif();
			}
			else if (token is _lex.token_.Le)
			{
				return new nub_.op_.IfThen();
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}
	}
}
