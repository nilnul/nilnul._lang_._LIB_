using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.regex_
{
	/// <summary>
	/// a lang contains no str.
	/// </summary>
	public  class Character:
		grammar_.single_.Character
		,

		IRegex
	{
		public Character(char c) : base(c)
		{
		}

		

		
	}
}
