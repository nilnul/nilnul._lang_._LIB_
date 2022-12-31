using nilnul.lang.eg.logic._walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._walk.nub.op
{

	


	public class OpX
	{

		static public OpI Token2Formula(_lex.token.DuoOpI token) {

			if (token is _lex.token.And)
			{
				return new And();
			}
			else if (token is _lex.token.Or)
			{
				return new Or();
			} else if (token is _lex.token.Eq) {
				return new Iif();
			}
			else if (token is _lex.token.Le)
			{
				return new IfThen();
			}
			else
			{
				throw new UnexpectedTypeException();
			}

		}
	}

	public class And:OpI
	{
		public override string ToString()
		{
			return "&";
		}

	}

	public class Or:OpI
	{
		public override string ToString()
		{
			return "|";
		}

	}

	public class IfThen:OpI
	{

		public override string ToString()
		{
			return "<=";
		}

	}

	public class Iif:OpI
	{
		public override string ToString()
		{
			return "~";
		}
	}

}
