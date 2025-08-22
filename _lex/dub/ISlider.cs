using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._lex.dub
{
	/// <summary>
	/// this is the output of the lex. 
	/// (token, ended) is always available, even when the str of tokens is already ended.
	/// the 'ended' component is true when the str of tokens is already ended.
	/// </summary>
	/// <remarks>
	/// this is also the input of <see cref="lang.ITex"/>.
	/// </remarks>
	///  		nilnul.obj.stream_.slider.of_.seq_._BySentinelX

	public interface ISlider
		 : nilnul.obj.stream_.ISlider
	{
	}
}
