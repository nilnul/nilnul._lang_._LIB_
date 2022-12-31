using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op.unary
{
	/// <summary>
	/// Iteration on DFA graph.
	/// </summary>
	public partial class Complement:UnaryI
	{
		public LangI eval(LangI arg)
		{


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
				return ! arg.contains(element);


				throw new NotImplementedException();
			}
		}
	}
}
