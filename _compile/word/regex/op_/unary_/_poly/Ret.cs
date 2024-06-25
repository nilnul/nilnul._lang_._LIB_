using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary_._poly
{
	public class Ret
		: nilnul.obj.op_.unary._call.ArgA<RegexI>
		,
		RegexI
	{
		private nilnul.NumI1 _num;

		public nilnul.NumI1 num
		{
			get { return _num; }
			set { _num = value; }
		}

		public Predicate<string> pred => throw new NotImplementedException();

		public Ret(RegexI arg, nilnul.NumI1 arg1) : base(arg)
		{
			_num = arg1;
		}

				
			

		
	}
}
