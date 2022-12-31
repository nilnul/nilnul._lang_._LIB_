using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using nilnul.obj.op_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_.join.cumulator_
{
	

	

	/// <summary>
	/// this explains why {""} is included as Regex
	/// </summary>
	public class Unardable
		:  Cumulator
		,
		op_.binary.cumulator_.UnardableI



	{
		
		public Unardable( ) 
		{
		}


		static public Unardable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unardable>.Instance;
			}
		}

		obj.op_.BinaryI<RegexI> BinderI<obj.op_.BinaryI<RegexI>>.binder => base.binder;

		//obj.op_.BinaryI<RegexI> AccumulatorI<RegexI, obj.op_.BinaryI<RegexI>>.binder => throw new NotImplementedException();
	}
}
