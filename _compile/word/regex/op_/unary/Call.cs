using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary
{
	public class Call<TOp> : nilnul.obj.op_.unary._call.OpArgA<TOp, RegexI>
		where TOp : regex.op_.UnaryI
	{
		public Call(TOp op, RegexI arg) : base(op, arg)
		{
		}
	}
}
