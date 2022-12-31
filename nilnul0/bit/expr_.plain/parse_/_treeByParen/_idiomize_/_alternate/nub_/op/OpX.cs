using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.op
{
	public class OpX
	{
		static public nilnul.bit.op_.BinaryI1 GetBitOp(
			nub_.OpI op	
		) {

			if (op is nub_.op_.And)
			{
				return  nilnul.bit.op_.binary_.And.Singleton;
			}
			else if (op is nub_.op_.Or)
			{
				return  nilnul.bit.op_.binary_.Or.Singleton;
			}

			else if (op is nub_.op_.IfThen)
			{
				return  nilnul.bit.op_.binary_.Imply.Singleton;
			}

			else if (op is nub_.op_.Iif)
			{
				return  nilnul.bit.op_.binary_.Eq.Singleton;
			}

			else 
			{
				throw new UnexpectedTypeException();
			}

		}


		static public OpI Token2Formula(_idiomize._lex.token_.DuoOpI token)
		{
			if (token is _idiomize._lex.token_.And)
			{
				return new nub_.op_.And();
			}
			else if (token is _idiomize._lex.token_.Or)
			{
				return new nub_.op_.Or();
			}
			else if (token is _idiomize._lex.token_.Eq)
			{
				return new nub_.op_.Iif();
			}
			else if (token is _idiomize._lex.token_.Le)
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
