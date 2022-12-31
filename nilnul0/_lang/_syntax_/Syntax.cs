using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang_._grammar
{
	/*The use of EBNFs doesn't distiguish between lexer and parser - only between terminal and non-terminal symbols. Terminal symbols describe the input, while non-terminal symbols describe the tree structure behind the input. In practice, terminal symbols are recognized by a lexer and non-terminal symbols are recognized by a parser. ANTLR imposes the convention that lexer rules start with an uppercase letter and parser rules with a lowercase letter. Lexer rules contain only either literals (along the use of EBNF symbols; literals can be both single characters and longer strings) or references to other lexer rules. Parser rules may reference parser and lexer rules as they wish and even include literals, but never only literals. See following sample grammar:

decl : 'int' ID '=' INT ';' // E.g., "int x = 3;"
       | 'int' ID ';'          // E.g., "int x;"
       ;
ID   : ('a'..'z' | 'A'..'Z')+;
INT  : '0'..'9'+;*/
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// syntax (句法) analysis
	/// </remarks>
	public interface SyntaxI {

	}
	
}
