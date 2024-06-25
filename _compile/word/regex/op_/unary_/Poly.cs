using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary_
{
	/// <summary>
	/// R^n, where n is natural number.
	///		R^1 = R,
	///		R^2 = R * R, where * means "Join"
	///		R^0 = {""}, the 
	/// </summary>
	public class Poly :

		regex.op_.UnaryI
	{
		private nilnul.Num1 _num;

		public nilnul.Num1 num
		{
			get { return _num; }
			set { _num = value; }
		}

		public Poly(nilnul.Num1 num)
		{
			_num = num;
		}

		public RegexI op(RegexI par)
		{
			return nilnul.obj.op_.binary.cumulator_.UnardableX.Poly(
op_.binary_.join.cumulator_.Unardable.Singleton
,
_num,
par
			);

			//if (_num ==0 )
			//{
			//	return op_.binary_.join.Cumulator.Singleton.initial;
			//}
			//return binary_.Join.Singleton.op( new Poly(_num - 1).op(par), par  );

		}
	}
}
