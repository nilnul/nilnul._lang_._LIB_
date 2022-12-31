using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax
{
	/// <summary>
	/// a set of production rules. This is the grammar of a sentence (within a sentence, we have idiom/短语). For a program of many sentenses, it's called Syntax
	/// </summary>
	/// <remarks>
	/// in js, we have lexical grammar and regexp grammar.
	/// or may be we also have sentential grammar / synctac grammar.
	/// Numeric String Grammar
	/// 
	/// </remarks>
	public interface IGrammar
	{

	}


	public interface GrammarI:IGrammar
		,_grammar_.PredI
	{

	}
	public interface GrammarI_contain:IGrammar
		,nilnul.txt._set_.ContainsI
	{

	}



}
