using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_
{
	public  interface IJoin

	{
	}
	//public class Join<T>
	//	: op_.BinaryI<T>
	//	where T : RegexI
	//{
	//	public T op(T par, T par1)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}
	public class Join
		: op_.BinaryI
	{
		public RegexI op(RegexI par, RegexI par1)
		{
			return new _join.Ret(par,par1);
		}

		static public Join Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Join>.Instance;
			}
		}

	}


}
