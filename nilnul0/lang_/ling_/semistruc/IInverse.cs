using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.ling
{
	/// <summary>
	/// use the code embedded in ling as the main representation of knowledge; and shrink the original unstructured text into comment;
	/// </summary>
	/// <remarks>
	/// traditionally we write in ling, and may embed some pseudo-algorithm in it;
	/// but we are transitioning gradually to inverse that to: use code to represent knowledge, and embed noncode in comment, which is processed as nonlang but ling by natural language processing, not the compiling defined here;
	/// eg:
	///		in ".git" description file:
	///			#commented names
	///			repo.name
	///			#
	///			
	///			# blank lines are valid in both comment and name (as empty part of the name), or any other lang;
	///	That's why <see cref="lang_.ICommentedTxt"/> puts comment last, whileas <see cref="lang_.ling_.EmbedStruct"/> puts comment(natural language) before structed (code)
	/// </remarks>

	internal class IInverse
	{
	}
}
