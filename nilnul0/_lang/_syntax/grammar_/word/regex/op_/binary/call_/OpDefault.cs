using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary.call_
{
	public class OpDefault<TOp> : regex.op_.binary.Call<TOp>
		where TOp : op_.BinaryI, new()
	{
		public OpDefault( RegexI arg, RegexI arg1) : base(nilnul.obj_.Singleton<TOp>.Instance, arg, arg1)
		{
		}
	}
}
