using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op.binary
{
	
	public partial class Union:BinaryI
	{
		public LangI eval(LangI a, LangI b)
		{
			throw new NotImplementedException();
		}



		public class Call : nilnul.obj.op.binary.closed.Args<LangI>
			,
			nilnul.character.LangI
		{

			public Call(LangI x, LangI y)
				: base(x, y)
			{

			}


			public bool contains(string element)
			{
				return arg.contains(element) | arg1.contains(element);

				throw new NotImplementedException();
			}
		}

	}
}
