using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_.join
{
	public interface ICumulator
	{
	}

	public interface CumulatorI
		: nilnul.obj.op_.binary.AccumulatorI<_lang._syntax.grammar_.IRegex>
		,ICumulator
	{
	}


	/// <summary>
	/// this explains why {""} is included as Regex
	/// </summary>
	public class Cumulator
		:  nilnul._lang._syntax.grammar_.regex.op_.binary.cumulator_.OpDefault<Join>



	{
		
		public Cumulator( ) : base(grammar_.regex_.Silent.Singleton)
		{
		}


		static public Cumulator Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
