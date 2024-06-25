using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex_
{
	/// <summary>
	/// a lang contains no str.
	/// </summary>
	public  class Empty:
		_lang._syntax.grammar_.Empty

		,
		RegexI
	{



		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}



	}
}
