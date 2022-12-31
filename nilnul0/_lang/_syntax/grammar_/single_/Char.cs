using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._lang._syntax.grammar_.single_
{
	/// <summary>
	/// a lang contains exactly one str, which is a str of exactly one char.
	/// </summary>
	public  class Character:
		nilnul.txt.Set,

		IGrammar
	{
		public char character { get {
				return this.Single()[0];
			} }
		public Character(char c):base(c.ToString())
		{

		}



	
	}
}
