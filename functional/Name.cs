using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.functional
{
	/// <summary>
	/// 
	/// </summary>
	internal class Name
	{
		/// eg:
		/// _Vod_0nonneg(int x)
		///		,where 0 nonneg means pars[0] is assumed nonneg
		///	_Vod_01nonneg(int x, int y)
		///		,where par0 as well par1 is each nonneg as assumed;
		///
		/// for pars count more than 10:
		///		: either the last shall be collapsed as array
		///		,: or the tail shall be wrapped as an object called options
		///		:
		///	, or if you insist:
		///		, used ⑮ etc, as in:
		///	_Vod_01⑮nonneg(int x, int y, ..., int x15_nonneg)
		///	
	}
}
