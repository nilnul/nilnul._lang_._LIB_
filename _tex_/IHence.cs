using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._tex_
{
	/// <summary>
	/// with the current token, parse forward till it's not possible (the parsing can stop any where, even advance 0 step, leaving the current unchanged), for a symbol.
	/// the history is at least current token, and past symbols can be stored as a environment state, or as the input, which can be consumed by the compilation.
	/// </summary>
	/// alias:
	///		hence
	///		reel
    public interface IHence
    {
    }

}
