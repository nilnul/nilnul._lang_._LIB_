using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op.unary
{
	public partial class AlphabetToAllSingletons
	{
		static public IEnumerable<string> Eval(AlphabetI alphabet) {
			foreach (var item in alphabet)
			{
				yield return item.ToString();
				
			}
		}

		public class Call
			:nilnul.obj.op.Call_ArgA<AlphabetI>
			,
			LangI
		{
			public Call(AlphabetI x)
				:base(x)
			{

			}


			public bool contains(string element)
			{
				foreach (var item in arg)
				{
					if (item.ToString()==element)
					{
						return true;
						
					}
					
				}
				return false;

				throw new NotImplementedException();
			}
		}
	}
}
