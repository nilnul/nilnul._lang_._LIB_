using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._tex.symbol
{
	/// <summary>
	/// this is the output of the tex. 
	/// (symbol, ended) is always available, even when the str of symbols is already ended.
	/// the 'ended' component is true when the str of symbols is already ended.
	/// </summary>
	///  		nilnul.obj.stream_.slider.of_.seq_._BySentinelX

	public interface ISlider
		 : nilnul.obj.stream_.ISlider
	{
	}
}
