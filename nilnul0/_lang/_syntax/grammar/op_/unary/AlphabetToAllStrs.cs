using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op.unary
{
	public partial class AlphabetToAll
	{

		public class Call
			:nilnul.obj.op.Call_ArgA<AlphabetI>
			,
			LangI
		{
			public Call(AlphabetI x)
				:base(x)
			{

			}



			/// <summary>
			/// If alphabet is not empty, this will be coutable.
			/// </summary>
			/// <param name="element"></param>
			/// <returns></returns>
			public bool contains(string element)
			{
				return new lang.op.unary.Iterate.Call(
					new AlphabetToAllSingletons.Call(arg)		
				).contains(element);
			}
		}
	}
}
