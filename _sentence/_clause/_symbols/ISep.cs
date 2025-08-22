using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._sentence._clause._symbols
{
	/// <summary>
	/// eg(as shown in quote):
	/// "
	///		the url:
	///			http://abc.com/def
	///		is here and denoted as:
	///		1
	///	;
	/// "
	/// the line break would partition the clause first, as lines; then for each line, space partition the line into spans|segments|phrases. the length of the span can hint precedence: the longer one partition first.
	/// 
	/// </summary>
	internal class ISep
	{
	}
}
