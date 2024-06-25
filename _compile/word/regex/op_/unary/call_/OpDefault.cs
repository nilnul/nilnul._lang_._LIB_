using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.unary.call_
{
	public class OpDefault<TOp> : regex.op_.unary.Call<TOp>
		where TOp : op_.UnaryI, new()
	{
		public OpDefault( RegexI arg) : base(nilnul.obj_.Singleton<TOp>.Instance, arg)
		{
		}
	}
}
