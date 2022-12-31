using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using nilnul.obj.op_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary
{
	public interface ICumulator
	{
	}

	public interface CumulatorI
		: nilnul.obj.op_.binary.AccumulatorI<_lang._syntax.grammar_.RegexI, op_.BinaryI>
		,ICumulator
	{
	}


	public class Cumulator<TOp>
		: nilnul.obj.op_.binary.Accumulator<RegexI, TOp>
		,
		CumulatorI
		
		where TOp: regex.op_.BinaryI



	{
		public Cumulator(RegexI regex,  TOp binder) : base(regex, binder)
		{
		}

		//BinaryI AccumulatorI<RegexI, BinaryI>.binder => binder;

		BinaryI BinderI<BinaryI>.binder => binder;//throw new NotImplementedException();
	}
	public class Cumulator : Cumulator<regex.op_.BinaryI>
		,
		CumulatorI
	{
		public Cumulator(RegexI regex, BinaryI binder) : base(regex, binder)
		{
		}
	}
}
