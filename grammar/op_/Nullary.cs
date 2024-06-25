using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.op
{
	public partial class Nullary
		:nilnul.obj.op.Nullary2<LangI>
		,
		
		NullaryI
	{
		public Nullary(LangI lang)
			:base(lang)
		{

		}

		public class Call
			:nilnul.obj.op.Nullary2<LangI>.Call
		{
			public Call(LangI lang)
				:base(lang)
			{

			}

		}
	}
}
