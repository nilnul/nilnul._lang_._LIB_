using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token
{
	

	public class LeftParen:Symbol
	{
		public override string ToString()
		{
			return "(";
		}

	}



	public class Var1 : Symbol, AtomicI
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


	public class RightParen:Symbol
	{
		public override string ToString()
		{
			return ")";
		}

	}

	public class Zero : Symbol, AtomicI
	{
		public override string ToString()
		{
			return "0";
		}

	}

	public class One : Symbol, AtomicI
	{
		public override string ToString()
		{
			return "1";
		}


	}


	public class And : Symbol, DuoOpI
	{

		public override string ToString()
		{
			return "&";
		}

	}

	public class Or : Symbol, DuoOpI
	{
		public override string ToString()
		{
			return "|";
		}

	}

	public class Not : Symbol, SimpleI
	{
		public override string ToString()
		{
			return "！";
		}


	}

	public class Le : Symbol, DuoOpI
	{
		public override string ToString()
		{
			return "<=";
		}

	}

	public class Eq : Symbol, DuoOpI
	{
		public override string ToString()
		{
			return "~";
		}


	}



}
