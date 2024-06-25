using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._lex
{
	/// <summary>
	/// like whitespace such as:
	///		<see cref="nilnul.character.set_.ascii_.Blank"/>, which is keyable from keyboard;
	/// </summary>
	/// <remarks>
	/// some char acts as lex separator. eg:
	///		' '
	///		','
	///		'.'
	///		''
	/// </remarks>
	/// vs:
	///		_, which is not an expr sep, but part of a word_.id;
	///			but within id, it might be parsed as a sep for <see cref="nilnul.txt_.vered_.id_"/>, and has sepcecial meaning therein;
	///			, or as a word_.num separator, as in "0.1_2"
	///		' ' which is a separator used between tokens. itself is meaningless;
	///		".", used in identity, or used in decimal like "0.3", or used in version, such as "3.1.2"
	///		',', used in composite expr, such as <see cref="nilnul.IObjs"/>
	///		":"	used for keyVal, or hierarchy.
	///		"()" used in tree, a compound structure.
	///		
	///		;
	///			,which is separator between sentences;
	///		
	///		
	///		
	internal class ISeparator
	{
	}
}
