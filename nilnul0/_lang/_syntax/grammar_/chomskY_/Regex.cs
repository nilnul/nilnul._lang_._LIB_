using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.regex
{
	/// <summary>
	/// A sub Lang expressed by finite operations (finity is always required in expression.). Regex is a sub-lang of an alphabet. That is a set of strings constructed on an alphabet. 
	/// </summary>
	/// <remarks>
	/// regex uses union, concat, and concat pow closure, 'cuz DFA supports such operations: concat is the edge, union is the fork of edges, concat pow closre is the self-loop of a node.
	/// </remarks>
	interface IRegex
	{



	}
}
