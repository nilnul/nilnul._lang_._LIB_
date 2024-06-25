using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary
{
	public class Call<TOp> : nilnul.obj.op_.binary._call.OpArgArg1A<TOp, RegexI>
		where TOp : regex.op_.BinaryI
	{
		public Call(TOp op, RegexI arg, RegexI arg1) : base(op, arg, arg1)
		{
		}
	}
}
