using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_
{
	

	public class LeftParen:TokenI
	{
		public override string ToString()
		{
			return "(";
		}

	}



	public class Var1 :  AtomicI
	{


		public StringBuilder name = new StringBuilder();

		
		public string name1
		{
			get { return name.ToString(); }
			//set { _name1 = value; }
		}


		public void append(char x)
		{
			name.Append(x);
		}

		public void _append(char? _notNull)
		{
			append(_notNull.Value);
		}

		public override string ToString()
		{
			return name.ToString();
		}

	}


	public class RightParen:TokenI
	{
		public override string ToString()
		{
			return ")";
		}

	}

	public class Zero :  AtomicI
	{
		public override string ToString()
		{
			return "0";
		}

	}

	public class One :  AtomicI
	{
		public override string ToString()
		{
			return "1";
		}


	}


	public class And :  DuoOpI
	{

		public override string ToString()
		{
			return "&";
		}

	}

	public class Or :  DuoOpI
	{
		public override string ToString()
		{
			return "|";
		}

	}

	public class Not :  SimpleI
	{
		public override string ToString()
		{
			return "！";
		}


	}

	public class Le :  DuoOpI
	{
		public override string ToString()
		{
			return "<=";
		}

	}

	public class Eq :  DuoOpI
	{
		public override string ToString()
		{
			return "~";
		}


	}



}
