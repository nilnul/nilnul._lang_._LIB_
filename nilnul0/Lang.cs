using computer.lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character
{
	/// <summary>
	/// Lang is a collection of string (words, sentences) of characters.
	/// </summary>
	/// <remarks>
	/// a research on programming language with Chomspky theory based.
	/// 
	/// </remarks>
	public partial class Lang
	{
		AlphabetI alphabet;
		List<ProductionI> productions;///finite.
		ProductionI goal;//must be in the productions;

		public Lang(AlphabetI alphabet,List<ProductionI> productions,ProductionI goal)
		{
			if (!productions.Contains(goal))
			{
				throw new Exception();
				
			}

			this.alphabet = alphabet;
			this.productions = productions;
			this.goal = goal;
		}
					



	}
}
