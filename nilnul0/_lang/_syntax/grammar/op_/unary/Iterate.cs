using nilnul.character.lang.op.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.character.lang.op.unary
{
	/// <summary>
	/// Iteration on DFA graph.
	/// </summary>
	public partial class Iterate:UnaryI
	{
		public LangI eval(LangI arg)
		{
			return new Call(arg);

			throw new NotImplementedException();
		}

		public class Call
			:nilnul.obj.op.Call_ArgA<LangI>, LangI
		{

			public Call(LangI lang):base(lang)
			{

			}



			public bool contains(string element)
			{

				var n = N.GetZero1();


				while (n<element.Length)	///this guarantees that Regex is recursive.
				{
					if (new ConcatPow.Call(n,arg).contains(element))
					{
						return true;
						
					}
					n++;
					
				}
				return false;


				throw new NotImplementedException();
			}
		}
	}
}
