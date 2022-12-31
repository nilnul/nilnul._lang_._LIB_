using nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_
{
	public class ArgX
	{

		static public AtomI AtomToken2DuoArg(_lex.token_.AtomicI atomToken) {
			if (atomToken is _lex.token_.Zero)
			{
				return new Zero();
			}
			else if (atomToken is _lex.token_.One)
			{
				return new One();
			}
			else if (atomToken is _lex.token_.Var1)
			{
				return new Var(atomToken as _lex.token_.Var1);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}
	}

	public interface ExprI {

	}


	public class DuoCall:ExprI
	{

		private ExprI _arg;

		public ExprI arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		private ExprI _arg1;

		public ExprI arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}

		public override string ToString()
		{

			return base.ToString();
		}

	}

	/// <summary>
	/// use Parenthesis in a linear txt to represent a tree which is nonlinear.
	/// </summary>
	public class ParenedArg:ArgI,NotArgI
	{

		private alter.vow_.wellFormed.Ed _expr;

		public alter.vow_.wellFormed.Ed expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public override string ToString()
		{
			return $"({_expr})";
        }

		public ParenedArg(alter.vow_.wellFormed.Ed formula)
		{
			_expr = formula;

		}



	}

	public interface NotArgI:SimptonI {

	}
	public class NotExpr:ArgI,NotArgI
	{
		private NotArgI _arg;

		public NotArgI arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public NotExpr(NotArgI arg)
		{
			_arg = arg;
		}

		public NotExpr(ParenedArg duoChain)
		{
			this._arg = duoChain;
		}

		public NotExpr(AtomicI atomic)
		{
			this._arg = ArgX.AtomToken2DuoArg(  atomic);
		}

		public override string ToString()
		{
			return $"!{_arg}";
		}
	}

	public interface SimptonI:ArgI {



	}

	public interface AtomI : ArgI ,NotArgI,SimptonI{

	}

	public class AtomA
	{
		static public AtomI Create(_lex.token_.AtomicI token) {

			if (token is _lex.token_.Zero)
			{
				return new Zero();
			}
			else if (token is _lex.token_.One)
			{
				return new One();
			}
			else if(token is _lex.token_.Var1)
			{
				return new Var(token as _lex.token_.Var1);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
		}
	}

	public class Var:AtomI,NotArgI
	{
		private _lex.token_.Var1 _token;

		public _lex.token_.Var1 token
		{
			get { return _token; }
			set { _token = value; }
		}

		public Var(_lex.token_.Var1 token)
		{
			_token = token;
		}

		public override string ToString()
		{
			return _token.ToString();
		}


	}

	public interface LiteralI:AtomI,NotArgI
	{


	}

	public class Zero:LiteralI
	{
		public override string ToString()
		{
			return "0";
		}

	}

	public class One:LiteralI
	{
		public override string ToString()
		{
			return "1";
		}

	}
}
