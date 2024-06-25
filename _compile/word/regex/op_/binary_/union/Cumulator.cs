using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_.binary_.union
{
	
	/// <summary>
	/// this explains why {} is defined as regex_.primitive
	/// </summary>

	public class Cumulator
		:
nilnul._lang._syntax.grammar_.regex.op_.binary.cumulator_.OpDefault<binary_.Union>



	{
		public Cumulator() : base(regex_.Empty.Singleton)
		{
		}
	}
}
