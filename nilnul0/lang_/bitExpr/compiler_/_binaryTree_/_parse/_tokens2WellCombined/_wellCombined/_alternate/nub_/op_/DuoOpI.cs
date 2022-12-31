using nilnul.lang.eg.logic._walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.op_
{
	//public class OpX
	//{
	//	static public OpI Token2Formula(_lex.token_.DuoOpI token) {
	//		if (token is _lex.token_.And)
	//		{
	//			return new And();
	//		}
	//		else if (token is _lex.token_.Or)
	//		{
	//			return new Or();
	//		} else if (token is _lex.token_.Eq) {
	//			return new Iif();
	//		}
	//		else if (token is _lex.token_.Le)
	//		{
	//			return new IfThen();
	//		}
	//		else
	//		{
	//			throw new UnexpectedTypeException();
	//		}
	//	}
	//}

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
