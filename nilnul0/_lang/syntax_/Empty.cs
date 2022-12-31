using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_
{
	/// <summary>
	/// a lang contains no str.
	/// </summary>
	public  class Empty:
		nilnul.txt.Set,

		_syntax.GrammarI
	{


		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}

		public Predicate<string> pred => contains;
	}
}
