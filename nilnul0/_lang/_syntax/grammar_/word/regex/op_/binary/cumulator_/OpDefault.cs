using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary.cumulator_
{
	


	public class OpDefault<TOp>
		: binary.Cumulator<TOp>
		where TOp: regex.op_.BinaryI,new()



	{
		public OpDefault(RegexI regex) : base(regex, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}
}
