using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex_
{
	/// <summary>
	/// a lang contains no str.
	/// </summary>
	public  class Silent:
		grammar_.Silent
		,

		RegexI
	{
		

		static public Silent Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Silent>.Instance;
			}
		}

		//public Predicate<string> pred => throw new NotImplementedException();
	}
}
