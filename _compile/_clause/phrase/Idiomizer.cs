using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_
{
	/*
	 vs: parser:
		only consider finite context.
		recursion is honored within word
		recursion is not considered by lexer over word
		 */
	/// <summary>
	/// input: tokens; output: idioms (including: expressions)
	/// chars to words
	/// </summary>
	/// <remarks>
	/// 词法分析，分词
	///		including :
	///			parsing from txt to obj
	///			or phrase obj to txt
	/// 
	/// </remarks>
	public interface IIdiomizer
	{
		//scanner
	}
}
