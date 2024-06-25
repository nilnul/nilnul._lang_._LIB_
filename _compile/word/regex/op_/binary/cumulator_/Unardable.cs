using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary.cumulator_
{
	public interface UnardableI: nilnul.obj.op_.binary.cumulator_.UnardableI<
		RegexI
		//,
		//op_.BinaryI
	>
		,
		CumulatorI
	{
	}
}
